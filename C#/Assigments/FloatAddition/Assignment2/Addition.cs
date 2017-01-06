using System.Text;

namespace AssignmentTwo
{
    /// <summary>
    /// Enum for all possible addition results of binary numbers.
    /// </summary>
    public enum ValueEnum
    {
        ZERO,
        ONE,
        TWO,
        THREE
    }
    /// <summary>
    /// Class which performs addition of two numbers bit by bit.
    /// </summary>
    class Addition
    {
        /// <summary>
        /// Adds two IEEE format numbers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        /// <see cref="https://www.tutorialspoint.com/computer_logical_organization/binary_arithmetic.htm"/>
        public string Add(string[] numbers)
        {
            StringManipulation manipulationObject = new StringManipulation();
            string[] equalLengthNumbers = manipulationObject.MakeEqualLength(numbers);
            ValueEnum sumEnum;
            StringBuilder firstNumberBuilder = new StringBuilder(manipulationObject.ReverseString(numbers[0]));
            StringBuilder secondNumberBuilder = new StringBuilder(manipulationObject.ReverseString(numbers[1]));
            StringBuilder sumBuilder = new StringBuilder();
            int sum = 0, carry = 0;
            int index = 0;

            for (int i = 0; i < firstNumberBuilder.Length; i++)
            {
                if (firstNumberBuilder[i] == '.' || secondNumberBuilder[i] == '.')
                {
                    index = i;
                    continue;
                }
                
                    sum = firstNumberBuilder[i] + secondNumberBuilder[i] + carry - 96;
                    sumEnum = (ValueEnum)sum;
                    switch (sumEnum)
                    {
                        case ValueEnum.ZERO:
                            sum = 0; carry = 0;
                            break;
                        case ValueEnum.ONE:
                            sum = 1; carry = 0;
                            break;
                        case ValueEnum.TWO:
                            sum = 0; carry = 1;
                            break;
                        case ValueEnum.THREE:
                            sum = 1; carry = 1;
                            break;
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
