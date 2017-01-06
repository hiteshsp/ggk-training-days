using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;

            Console.WriteLine("Enter the First Number");
            a = Console.ReadLine();
            Console.WriteLine("Enter the Second Number");
            b = Console.ReadLine();

            new Sum(a, b);
            
            
        }
       
    }
}
