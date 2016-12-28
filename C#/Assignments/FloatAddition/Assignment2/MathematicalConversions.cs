using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class MathematicalConversions
    {
        /// <summary>
        /// It converts float to binary.
        /// </summary>
        /// <param name="exponent"></param>
        public string DecimalToBinary(int number)
        {
            int remainder;
            string result = string.Empty;
            if (number == 0)
            {
                result = "0";
            }
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }
            
            return result;
        }

        /// <summary>
        /// It converts the fractional part of number to binary for with needed padding
        /// according to IEEE 754 format.
        /// </summary>
        /// <param name="fractionPart"></param>
        /// <returns></returns>
        /// <see cref="http://class.ece.iastate.edu/arun/Cpre305/ieee754/ie4.html"/>
        public string Mantissa(float fractionPart)
        {
            string binaryMantissa = string.Empty;
            int i = 0;
            while (i < 23)
            {
                fractionPart *= 2;
                binaryMantissa += ((int)fractionPart);
                fractionPart -= (int)fractionPart;
                i++;
            }
            binaryMantissa = binaryMantissa.PadRight(23, '0');
            
            return binaryMantissa;
        }
        /// <summary>
        /// Converts a binary number to floating point number.
        /// </summary>
        /// <param name="number"></param>
        public void BinaryToFloat(string number)
        {
            StringManipulations stringIndex = new StringManipulations();
            int index = stringIndex.IndexOf(number,'.');
            Console.WriteLine(number);
            string partOneNumber = stringIndex.Substring(number, 0, index);
            string partTwoNumber = stringIndex.Substring(number, index + 1, number.Length - index - 1);

            float integralPart = Convert.ToInt32(partOneNumber, 2);
            int iterator;
            float fractionalPart = 0;
            for (iterator = 0; iterator < partTwoNumber.Length - 1; iterator++)
            {
                fractionalPart += (float)((partTwoNumber[iterator] - 48) / Math.Pow(2, iterator + 1));

            }
            Console.WriteLine(integralPart + fractionalPart);
        }

    }
}
