using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Reference: http://class.ece.iastate.edu/arun/Cpre305/ieee754/ie4.html 
namespace AssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input two numbers.
            try
            {
                var firstNumber = float.Parse(Console.ReadLine());
                var secondNumber = float.Parse(Console.ReadLine());

                // Instance for FloatToIEEE class.
                FloatToIEEE floatInstance = new FloatToIEEE();

                // Binary representation of the numbers.
                var binaryFirstNumber = floatInstance.FloatToBinary(firstNumber);
                var binarySecondNumber = floatInstance.FloatToBinary(secondNumber);

                // Normalized Numbers to common exponent (i.e 2^0) here.            
                string normalizedFirstNumber = floatInstance.Normalize(binaryFirstNumber.Power, binaryFirstNumber.Mantissa);
                string normalizedSecondNumber = floatInstance.Normalize(binarySecondNumber.Power, binarySecondNumber.Mantissa);

                // Instance for performing all the mathematical conversions.
                MathematicalConversions mathInstance = new MathematicalConversions();

                // Instance for adding the two numbers.
                Addition additionInstance = new Addition();

                // String storing the sum of two numbers.
                string sumOfNumbers = additionInstance.Add(normalizedFirstNumber, normalizedSecondNumber);

                // Converting the result back to binary.
                mathInstance.BinaryToFloat(sumOfNumbers);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
