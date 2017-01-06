namespace ConsoleApplication2
{
    class Sum
    {
        /// <summary>
        /// Adds Two Numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Sum(string a, string b)
        {
            int number1, number2;

            number1 = a[0];
            number2 = b[0];
            StringManipulation manipulationObj = new StringManipulation();
            a = manipulationObj.ReverseString(a);
            b = manipulationObj.ReverseString(b);

            a = a.TrimEnd('-');
            b = b.TrimEnd('-');

            Addition addObj = new Addition();
            if (number1 == 45 && number2 == 45)
            {
                addObj.AddNegativeNumbers(a, b);

            }
            else if (number1 == 45 && number2 != 45)
            {
                addObj.AddOneNegativeNumber(a, b);
            }
            else if (number1 != 45 && number2 == 45)
            {
                addObj.AddOneNegativeNumber(a, b);
            }
            else if (number1 != 45 && number2 != 45)
            {
                addObj.AddPositiveNumbers(a, b);
            }

        }
    }
}
