using System;
using System.Threading.Tasks;

namespace LoginApp
{
    class Program
    {
        /// <summary>
        /// Driver class for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu firstScreen = new Menu();

            bool canContinue = false;

            // Iterations for the Presentation Layer.
            do
            {
                Console.Clear();

                Choice selectedChoice = firstScreen.SelectChoice();

                Task.WaitAll (firstScreen.Execute(selectedChoice));

                canContinue = firstScreen.IterationFlag();

            } while (canContinue);
        }
    }
}
