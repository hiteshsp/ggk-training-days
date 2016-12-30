using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    /// <summary>
    /// Class which performs addition of two numbers bit by bit.
    /// </summary>
    class Addition
    {
        /// <summary>
        /// Enum for all possible addition results of binary numbers.
        /// </summary>
        public enum value
        {
            ZERO = 0,
            ONE = 1,
            TWO = 2,
            THREE = 3
        }
        /// <summary>
        /// Adds two IEEE format numbers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        /// <see cref="https://www.tutorialspoint.com/computer_logical_organization/binary_arithmetic.htm"/>
        public string Add(string firstNumber, string secondNumber)
        {
            StringManipulations manipulationObject = new StringManipulations();
            Tuple<string, string> numbers = manipulationObject.MakeEqualLength(firstNumber, secondNumber);

            value sumEnum;
            StringBuilder firstNumberBuilder = new StringBuilder(manipulationObject.ReverseString(numbers.Item1));
            StringBuilder secondNumberBuilder = new StringBuilder(manipulationObject.ReverseString(numbers.Item2));
            StringBuilder sumBuilder = new StringBuilder();

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            int sum = 0, carry = 0;

            int index = 0;
            for (int i = 0; i < firstNumberBuilder.Length; i++)
            {
                if (firstNumberBuilder[i] == '.' || secondNumberBuilder[i] == '.')
                {
                    index = i;
                    continue;
                }
                else
                {
                    sum = firstNumberBuilder[i] + secondNumberBuilder[i] + carry - 96;
                    sumEnum = (value)sum;
                    switch (sumEnum)
                    {
                        case value.ZERO:
                            sum = 0; carry = 0;
                            break;
                        case value.ONE:
                            sum = 1; carry = 0;
                            break;
                        case value.TWO:
                            sum = 0; carry = 1;
                            break;
                        case value.THREE:
                            sum = 1; carry = 1;
                            break;
                    }
                }
                sumBuilder.Append(sum);
            }
            if (carry == 1)
            {
                sumBuilder.Append(carry);
            }
            sumBuilder.Insert(index, '.');

            return manipulationObject.ReverseString(sumBuilder.ToString());
        }
    }
}
