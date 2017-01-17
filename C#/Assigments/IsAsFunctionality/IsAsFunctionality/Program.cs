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
            BaseClass a = new BaseClass();
            SubClass b = new SubClass();
            
            // Is Implementation.
            if(b.Is(typeof(BaseClass)))
            {
                Console.WriteLine("'IS' Works !");
            }
          
            // As Implementation.
            a = b.As(typeof(BaseClass));
            
            Console.WriteLine(a);
        }
    }
}
