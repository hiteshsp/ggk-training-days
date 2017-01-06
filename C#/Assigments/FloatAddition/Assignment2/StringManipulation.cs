namespace AssignmentTwo
{
    /// <summary>
    /// Class which has all string manipulation methods.
    /// </summary>
    class StringManipulation
    {
        /// <summary>
        /// It equals the length of the two bit strings.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        /// <see cref="http://www.geeksforgeeks.org/add-two-bit-strings/"/> 
        public string[] MakeEqualLength(string[] strings)
        {
            int firstLength = strings[0].Length;
            int secondLength = strings[1].Length;
            
            if (firstLength < secondLength)
            {
                for (int i = 0; i < secondLength - firstLength; i++)
                {
                    strings[0]  = '0' + strings[0];
                }
                
            }
            else if (firstLength > secondLength)
            {
                for (int i = 0; i < firstLength - secondLength; i++)
                    strings[1] = '0' + strings[1];
            }
            return strings;
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
            for (i = 0; i < text.Length; i++)
            {
                if (value == text[i])
                    break;
            }
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
            {
                result += text[i];
            }
            return result;
        }

    }
}
