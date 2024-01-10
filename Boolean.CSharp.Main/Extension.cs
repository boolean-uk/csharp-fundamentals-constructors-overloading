



using NUnit.Framework.Constraints;
using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        
        public float add(float a, float b)
        {
            return a + b;
        }

        public double add(double a, double b)
        {
            return a + b;
        }

        public float subtract(float a, float b)
        {
            return a - b;
        }

        public string subtract(string a, char b)
        {
            return a.Replace(b.ToString(), "");
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public string multiply(string a, int b)
        {
            string outputString = "";
            for (int i = 0; i < b; i++)
            {
                if (i == 0)
                {
                    outputString += a;
                    continue;
                }
                outputString += "," + a;
            }

            return outputString;
        }

        public int[] multiply(string[] strings, int multiplier)
        {
            int[] outputArray = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                int toNumber = Int32.Parse(strings[i]);
                outputArray[i] = toNumber * multiplier;  
            }

            return outputArray;
        }
        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]

    }
}
