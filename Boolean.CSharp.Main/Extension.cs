



using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float float1, float float2)
        {
            return float1 + float2;
        }
        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double double1, double double2)
        {
            return double1 + double2;
        }
        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float subtract(float float1, float float2)
        {
            return float1 - float2;
        }
        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string string1, char char1)
        {
            return string1.Replace(char1.ToString(), "");
        }
        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int int1, int int2)
        {
            return int1 * int2;
        }
        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string string1, int int1)
        {
            string multiplied_string = "";
            for(int i = 0; i < int1; i++)
            {
                multiplied_string += string1 + ",";
            }
            return multiplied_string[..(multiplied_string.Length-1)];
        }
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] numbers, int int1)
        {
            int[] ints = new int[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                ints[i] = Int32.Parse(numbers[i]) * int1;
            }

            return ints;
        }
    }
}
