using System;

namespace IsAsFunctionality
{
    class BaseClass
    {
    }
    class SubClass : BaseClass
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass a = new BaseClass();
            SubClass b = new SubClass();

            if(b.Is(typeof(BaseClass)))
            {
                Console.WriteLine("'IS' Works !");
            }
            object t = "test";
            Console.WriteLine(t.GetType());
            a = b.As(typeof(BaseClass));
            b = a.As(typeof(SubClass));
            
        }
    }
}
