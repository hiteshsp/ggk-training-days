using System;
using StaticDLL;
using System.Diagnostics;

namespace StaticVariable
{
    /// <summary>
    /// Driver class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value In First Project " + DLL.integer);
            Process processObj = new Process();
            processObj.StartInfo.FileName = @"C:\Users\hiteshwara.sharma\Documents\visual studio 2015\Projects\StaticVariable\StaticVariableTwo\bin\Debug\StaticVariableTwo.exe";
            processObj.Start();
            Console.WriteLine("Value After Process Two " + DLL.integer);
        }
    }
}
