using System;
using System.Threading;

namespace OutParameter
{   
    /// <summary>
    /// Driver Class.
    /// </summary>
    class Program
    {
      /// <summary>
      /// Driver Method.
      /// </summary>
      /// <param name="args"></param>
        static void Main(string[] args)
        {
            int y = 10;

            Child childObj = new Child();
            
            Thread childThread = new Thread(() => childObj.OutParameterTest(out y));

            childThread.Start();
            Thread.Sleep(100);

            childObj.Print(y);
            Thread.Sleep(1000);

            Console.WriteLine("After Init " + y); 
            
        }
    }
}
