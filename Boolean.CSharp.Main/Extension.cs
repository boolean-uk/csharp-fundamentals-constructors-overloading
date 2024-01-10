



using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
      
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]

        public float add(float x, float y)
        {
            return x + y;
        }

        public double add(double x, double y)
        {
            return x + y;
        }

        public float subtract(float x, float y)
        {
            return x - y;
        }

        public string subtract(string x, char y)
        {
            return x.Remove(x.IndexOf(y), 1);
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public string multiply(string x, int y)
        {
            return string.Join(",", Enumerable.Repeat(x, y));
        }

        public int[] multiply(string[] strings, int number)
        {
            int[] result = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                if (!int.TryParse(strings[i], out int val)) throw new Exception("Not a valid number");
                result[i] = val * number;

            }
            return result;
        }

    }
}
