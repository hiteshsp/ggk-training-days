using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class FloatToIEEE
    {

        /// <summary>
        /// It converts a single precision number into a struct with properties
        /// signBit exponent mantissa power of the exponent.
        /// </summary>
        /// <param name="data">
        /// Input a number of type Float and get its binary representation.
        /// </param>
        /// <example> This sample shows how to call the SaveData 
        /// method from a wireless device.
        /// <code>
        /// 
        ///IEEE754 instance = FloatToBinary(float number)
        ///
        ///</code>
        /// <returns>IEEE754 object</returns>
        /// <see cref="http://class.ece.iastate.edu/arun/Cpre305/ieee754/ie4.html"/>
        public IEEE754 FloatToBinary(float number)
        {

            bool signBit = false;
            int i = 0;
            float mantissa = 0;
            IEEE754 result = new IEEE754();
            MathematicalConversions mathObject = new MathematicalConversions();
            if (number.ToString().Contains('-'))
            {
                number *= -1;
                signBit = true;
            }

            if (number != 0)
                {
                    if (number < 1)
                    {
                        while (mantissa < 1.0)
                        {
                            i--;
                            mantissa = number / (float)Math.Pow(2, i);

                        }
                    }
                    else
                    {
                        mantissa = number;
                        while (mantissa > 2)
                        {
                            i++;
                            mantissa = number / (float)Math.Pow(2, i);
                        }
                    }
                }
            
            int exponent = 127 + i;
            string binaryConversion = mathObject.DecimalToBinary(exponent);
            int binaryExponent = Convert.ToInt32(binaryConversion);
            mantissa = mantissa - (int)mantissa;
            StringBuilder mantissaBinary = new StringBuilder(mathObject.Mantissa(mantissa));
            mantissaBinary.Insert(0, '1');

            result.SignBit = (byte)((signBit) ? 1 : 0);
            result.Exponent = binaryExponent;
            result.Mantissa = mantissaBinary.ToString();
            result.Power = i;
            return result;

        }
       
        /// <summary>
        /// Normalizes the number to IEEE representation i.e exponent 2^0
        /// </summary>
        /// <param name="exponent"></param>
        /// <param name="mantissa"></param>
        /// <returns>string</returns>
        /// <see cref="http://teaching.idallen.com/cst8281/10w/notes/100_ieee754_conversions.txts"/>
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
