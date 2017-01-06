using System;
namespace ConsoleApplication2
{
    /// <summary>
    /// Performs Logic on test cases.
    /// </summary>
    class Addition
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static string Add(string a, string b)
        {
            int i = 0, j = 0, carry = 0, sum = 0;
            string result = null;
            object temperory = (a.Length < b.Length) ? (a = a.PadRight(b.Length, '0')) : (b = b.PadRight(a.Length, '0'));
            StringManipulation manipulationObj = new StringManipulation();
            int[] numbersA = manipulationObj.SplitNumbers(a);
            int[] numbersB = manipulationObj.SplitNumbers(b);
            
            while (i < numbersA.Length || j < numbersB.Length)
            {

                if (carry != 0)
                {
                    sum = numbersA[i] + numbersB[j] + carry;

                    if (sum > 9 && sum != 10)
                    {
                        carry = (sum) / 10;
                        sum = (sum) % 10;
                    }

                    else if (sum == 10)
                    {
                        carry = 1;
                        sum = 0;
                    }

                }
                else if (carry == 0)
                {
                    sum = numbersA[i] + numbersB[j];

                    if (sum > 9 && sum != 10)
                    {
                        carry = (sum) / 10;
                        sum = (sum) % 10;
                    }

                    else if (sum == 10)
                    {
                        carry = 1;
                        sum = 0;
                    }
                }
                result += sum;
                i++;
                j++;
            };
            if (carry != 0)
            {
                result += carry;
            }
            return result;
        }
      
        /// <summary>
        /// Adds two negative numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void AddNegativeNumbers(string a, string b)
        {

            string result = Add(a, b);
            result += '-';
            result = new StringManipulation().ReverseString(result);
            Console.WriteLine(result);

        }
        /// <summary>
        /// One Negative and One Positive Number.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void AddOneNegativeNumber(string a, string b)
        {


        }
        /// <summary>
        /// Adds two positive numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void AddPositiveNumbers(string a, string b)
        {
            string result = Add(a, b);
            result = new StringManipulation().ReverseString(result);
            Console.WriteLine(result);

        }

    }
}
