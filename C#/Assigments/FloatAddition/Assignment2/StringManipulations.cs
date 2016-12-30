using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    /// <summary>
    /// Class which has all string manipulation methods.
    /// </summary>
    class StringManipulations
    {
        /// <summary>
        /// It equals the length of the two bit strings.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/add-two-bit-strings/"/> 
        public Tuple<string, string> MakeEqualLength(string stringOne, string stringTwo)
        {
            int firstLength = stringOne.Length;
            int secondLength = stringTwo.Length;

            if (firstLength < secondLength)
            {
                for (int i = 0; i < secondLength - firstLength; i++)
                {
                    stringOne = '0' + stringOne;
                }


            }
            else if (firstLength > secondLength)
            {
                for (int i = 0; i < firstLength - secondLength; i++)
                    stringTwo = '0' + stringTwo;
            }
            return new Tuple<string, string>(stringOne, stringTwo);
        }
        /// <summary>
        /// Returns index of the character
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int IndexOf(string text, char value)
        {
            int i;
            for (i = 0; (value != text[i]) && (i < text.Length); i++) ;
            return i;

        }
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
        /// Returns a string from specified startIndex
        /// </summary>
        /// <param name="number"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public string Substring(string text, int startIndex, int length)
        {
            string result = string.Empty;
            for (int i = startIndex; i < length + startIndex; i++)
                result += text[i];
            return result;
        }

    }
}
