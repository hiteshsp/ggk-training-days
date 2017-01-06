using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class StringManipulation
    {
        /// <summary>
        /// Reverses the string 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReverseString(string text)
        {
            char[] tokens = text.ToCharArray();
            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                tokens[i] = text[j];
                tokens[j] = text[i];
            }
            return new string(tokens);
        }
        /// <summary>
        /// Splits numbers and returns an integer array of digits.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        /// <see cref="https://www.quora.com/How-can-I-convert-a-string-to-an-int-array-in-C Author: Dinesh Kumar Nayak"/>
        public int[] SplitNumbers(string a)
        {
            int[] intArray = a.Select(c => c - '0').ToArray();
            return intArray;
        }
    }
}
