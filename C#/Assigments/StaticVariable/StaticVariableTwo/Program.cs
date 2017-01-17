using System;
using StaticDLL;
namespace StaticVariableTwo
{
    /// <summary>
    /// Another Driver class which is invoked by another project.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DLL.integer = 89;
            Console.WriteLine("Value at Second Project " + DLL.integer);
            Console.ReadKey();
        }
    }
}
