



using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Boolean.CSharp.Main
{
    public class Extension
    {

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)

        public float add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)

        public float add(double number1, double number2)
        {
            float sum = (float)number1 + (float)number2;
            return sum;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)

        public float subtract(float number1, float number2)
        {
            float sum = number1 - number2;
            return sum;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        //
        public string subtract(string inputString, char charToRemove)
        {
            // Use Replace method to remove all instances of the specified char
            string result = inputString.Replace(charToRemove.ToString(), "");
            return result;
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)

        public int multiply(int number1, int number2)
        {
            int mult = number1 * number2;
            return mult;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string inputString, int times)
        {
            if (times <= 0)
            {
                throw new ArgumentException("The number of times should be greater than zero.");
            }

            // Use StringBuilder to efficiently concatenate repeated strings
            StringBuilder resultBuilder = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                resultBuilder.Append(inputString);
                if (i < times - 1)
                {
                    resultBuilder.Append(",");
                }
            }

            return resultBuilder.ToString();
        }


        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] numbers, int multiplier)
        {
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                // Use int.Parse to convert the string to an int and then multiply by the multiplier
                result[i] = int.Parse(numbers[i]) * multiplier;
            }

            return result;
        }
    }
}
