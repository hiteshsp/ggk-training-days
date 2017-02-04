using System;
namespace IsAsFunctionality
{
    /// <summary>
    /// Driver Class for IsAsFunctionality.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Driver Method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = 10;

            // Value Type Check For "IS".
            if (a.Is(typeof(float)))
            {
                Console.WriteLine("Voila!");
            }

            SubClass subClassObj = new SubClass();
            
            // Reference Type Check For "IS".
            if (subClassObj.Is(typeof(BaseClass)))
            {
                Console.WriteLine("'IS' Works !");
            }
            
            // Nullable Object Check For "AS".
            int? nullableObject = subClassObj.As<Nullable<int>>();
            Console.WriteLine(nullableObject);

            // BaseClass Check For "AS".
            BaseClass baseClassObj = subClassObj.As<BaseClass>();
            Console.WriteLine(baseClassObj);

        }
    }
}
