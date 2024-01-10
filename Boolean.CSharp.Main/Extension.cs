



using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

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


        public string subtract(string source, char z)
        {
            return source.Replace(z.ToString(), "");
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public string multiply(string source, int v)
        {
            string[] repeat = Enumerable.Repeat(source, v).ToArray();
            return String.Join(",", repeat);
        }

        public int[] multiply(string[] source, int multiplier)
        {
            //int[] nums = new int[source.Length];
            List<int> num = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                
                num.Add(int.Parse(source[i]) * multiplier);
            }
            return num.ToArray();


        }
    }
}
