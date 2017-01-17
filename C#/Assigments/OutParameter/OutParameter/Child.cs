using System;
using System.Threading;


namespace OutParameter
{
    /// <summary>
    /// Child class which takes the out parameter.
    /// </summary>
    class Child
    {
        /// <summary>
        /// Prints the value of parameter to console.
        /// </summary>
        /// <param name="x"></param>
        public void Print( int x)
        {
            Console.WriteLine("Print before init " +  x);
        }
        /// <summary>
        /// Takes the out parameter and updates the parameter.
        /// </summary>
        /// <param name="x"></param>
        public void OutCheck(out int x)
        {
            Thread.Sleep(1000);
            x = 20;
            Thread.Sleep(100);


        }
    }
}
