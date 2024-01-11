

using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {
        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float AddTwoFloats(float number1, float number2)
        {
            return number1 + number2;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double AddTwoDoubles(double number1, double number2)
        {
            return number1 + number2;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float SubtractTwoFloats(float number1, float number2)
        {
            return number1 - number2;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        public string SubtractCharFromString(string source, char charToRemove)
        {
            return source.Replace(charToRemove.ToString(), string.Empty);
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int MultiplyTwoInts(int number1, int number2)
        {
            return number1 * number2;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma.
        // E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string MultiplyStringWithComma(string inputString, int count)
        {
            return string.Join(",", Enumerable.Repeat(inputString, count));
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int.
        // The method should return an array of ints that contain the value of multiplying each String number by the provided int
        // E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] MultiplyStringArrayWithInt(string[] stringArray, int multiplier)
        {
            return stringArray.Select(s => int.Parse(s) * multiplier).ToArray();
        }
    }
}
