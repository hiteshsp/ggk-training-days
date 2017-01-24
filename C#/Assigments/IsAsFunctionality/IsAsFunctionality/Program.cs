using System;
namespace IsAsFunctionality
{
    /// <summary>
    /// Driver Class for IsAsFunctionality.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClassObj = new BaseClass();
            SubClass subClassObj = new SubClass();
            
            if (subClassObj.Is(typeof(BaseClass)))
            {
                Console.WriteLine("'IS' Works !");
            }

            baseClassObj = subClassObj.As<BaseClass>();
            Console.WriteLine(baseClassObj);

        }
    }
}
