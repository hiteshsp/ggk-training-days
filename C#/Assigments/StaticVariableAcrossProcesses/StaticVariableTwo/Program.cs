using System;
using StaticDLL;
namespace StaticVariableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL.integer = 89;
            Console.WriteLine("Value at Second Project "+ DLL.integer);
            Console.ReadKey();
        }
    }
}
