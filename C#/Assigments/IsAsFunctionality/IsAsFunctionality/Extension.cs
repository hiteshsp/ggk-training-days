using System;

namespace IsAsFunctionality
{
    static class Extension
    {
        public static bool Is(this object obj, Type className)
        {
            Type objType = obj.GetType();

            return className.IsAssignableFrom(objType);

        }        
        public static dynamic As(this object obj, Type className)
        {
            if (obj.Is(className))
            {
                return obj;
            }
            return null;
        }
    }
}
