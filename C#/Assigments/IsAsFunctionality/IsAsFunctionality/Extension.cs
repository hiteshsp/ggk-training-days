using System;

namespace IsAsFunctionality
{
    /// <summary>
    /// Class for Is and As Implemenatation.
    /// </summary>
    static class Extension
    {
        /// <summary>
        /// Returns true if a object is of assignable type.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static bool Is(this object obj, Type className)
        {
            if (obj != null)
            {
                Type objType = obj.GetType();
                return className.IsAssignableFrom(objType);
            }
            return false;
        }        
        /// <summary>
        /// Returns the object after assigning its type.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static T As<T>(this object obj)
        {
            if (!(typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(Nullable<>)) && typeof(T).BaseType == typeof(ValueType))
            {
                throw new ValueTypeException();
            }
            return obj.Is(typeof(T)) ? (T)obj : default(T);
        }
    }
}
