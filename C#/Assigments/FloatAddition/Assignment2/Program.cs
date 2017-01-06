using System;

namespace AssignmentTwo
{
    /// <summary>
    /// Driver Class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Input two numbers.
                var firstNumber = float.Parse(Console.ReadLine());
                var secondNumber = float.Parse(Console.ReadLine());

                // Instance for FloatToIEEE class.
                FloatToIEEE floatObj = new FloatToIEEE();

                // Instance for performing all the mathematical conversions.
                MathematicalConversion mathInstance = new MathematicalConversion();

                // Instance for adding the two numbers.
                Addition additionObj = new Addition();

                // String storing the sum of two numbers.
                string sumOfNumbers = additionObj.Add(floatObj.NormalizeTwoNumbers(firstNumber, secondNumber));

                // Converting the result back to binary.
                float result = mathInstance.BinaryToFloat(sumOfNumbers);

                // Result of the two numbers is displayed.
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
