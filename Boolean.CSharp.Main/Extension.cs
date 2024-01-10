



using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Boolean.CSharp.Main
{
    public class Extension
    {

        //Implement the following methods:


        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float a, float b)
        {
            return a + b;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double a, double b)
        { return a + b;}

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float subtract(float a, float b)
        {
            return a - b;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        public string subtract(string s, char c)
        {
            string output = "";
            string[] split = s.Split(c);
            foreach (string part in split)
                output += part; 
            return output;
            
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)

        public int multiply(int a, int b)
        {
            return a * b;
        }
        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string s, int a) 
        {
            string result = ""; 
            for (int i = 0; i < a; i++)
            {   
                result += s;
                if (i + 1 < a) result += ",";
            }
            return result;
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] strings, int a)
        {
            int[] result = new int[strings.Length]; 
            try
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    result[i] = Int32.Parse(strings[i]) * a;
                }
            }
            catch { }
            return result;
        }
    }
}
