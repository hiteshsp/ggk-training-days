using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            Child childObj = new Child();
            Thread childThread = new Thread(() => childObj.Method(out y));
            childThread.Start();
            Thread.Sleep(100);
            childObj.print(y);
            Thread.Sleep(1000);
            Console.WriteLine("after Init " + y); 
            
        }
    }
}
