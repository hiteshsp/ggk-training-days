using System;
using FactoryPatternLoginPage;

namespace FactoryPatternLogicPage
{
    /// <summary>
    /// Driver class for the Program.
    /// </summary>
    class PresentatonLayer
    {
        /// <summary>
        /// Entry Point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Portal !");
            Console.WriteLine("------------------------");
            MainScreen msObj = new MainScreen();
        }
    }
}

