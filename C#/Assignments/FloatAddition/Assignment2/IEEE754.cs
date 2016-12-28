using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class IEEE754
    {
       
            private byte sign;
            private int exponent;
            private int power;
            private string mantissa;

            public byte SignBit
            {
                get
                {
                    return sign;
                }
                set
                {
                    sign = value;
                }


            }
        public int Exponent { get; set; }
        public int Power { get; set; }
        public string Mantissa { get; set; }
        public string Normalize(int exponent, string mantissa)
        {
            // input 8, 1.101110101001 output : 101110101.11
            StringBuilder mantissaBuilder = new StringBuilder(mantissa);
            int exponentIterator = exponent;
            if (exponent < 0)
            {
                while (exponentIterator < 0)
                {
                    mantissaBuilder.Length--;
                    mantissaBuilder.Insert(0, '0');
                    exponentIterator++;
                }
                mantissaBuilder.Insert(1, '.');
            }
            else
            {
                while (exponentIterator > 0)
                {
                    mantissaBuilder.Insert(mantissaBuilder.Length, '0');
                    exponentIterator--;
                }
                mantissaBuilder.Insert(exponent + 1, '.');
            }
            return mantissaBuilder.ToString();
        }


    }
}
