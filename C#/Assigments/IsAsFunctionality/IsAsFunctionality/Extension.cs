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
            Type objType = obj.GetType();

            return className.IsAssignableFrom(objType);

        }        
        /// <summary>
        /// Returns the object after assigning its type.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static dynamic As(this object obj, Type className)
        {
            return obj.Is(className) ? obj : null;
        }
    }
}
