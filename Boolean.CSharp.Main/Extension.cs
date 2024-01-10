



using NUnit.Framework;
using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {
        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float value1, float value2) 
        { 
            return value1 + value2;
        }
        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double value1, double value2) 
        {
            return value1 + value2; 
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float subtract(float value1, float value2) 
        {
            float returnVal = value1 - value2;
            return returnVal;
        }


        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string stringValue, char charValue) 
        {
            return stringValue.Replace(charValue.ToString(), "");
        }


        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int value1, int value2) 
        { 
            return value1 * value2;
        }


        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string baseString, int multiply) 
        {
            return string.Join(",", Enumerable.Repeat(baseString, multiply));
        }


        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] strings, int multiplier) 
        {
            int[] intArray = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++) 
            {
                int transformedValue = int.Parse(strings[i]) * multiplier;
                intArray[i] = transformedValue;
            }
            Console.WriteLine(intArray);
            return intArray;
        }
    }
}
