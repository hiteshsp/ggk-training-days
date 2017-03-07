using System;
using System.Threading;
namespace OutParameter
{
    /// <summary>
    /// Child Class.
    /// </summary>
    class Child
    {
        /// <summary>
        /// Print Method.
        /// </summary>
        /// <param name="x"></param>
        public void Print(int x)
        {
            Console.WriteLine("Print before init " + x);
        }
        /// <summary>
        /// Method consuming "out" parameter.
        /// </summary>
        /// <param name="x"></param>
        public void OutParameterTest(out int x)
        {
            Thread.Sleep(1000);
            x = 20;
            Thread.Sleep(100);
        }
    }
}
