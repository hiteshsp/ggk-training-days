using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OutParameter
{
    class Child
    {
        public void print( int x)
        {
            Console.WriteLine("Print before init " +  x);
        }
        public void Method(out int x)
        {
            Thread.Sleep(1000);
            x = 20;
            Thread.Sleep(100);


        }
    }
}
