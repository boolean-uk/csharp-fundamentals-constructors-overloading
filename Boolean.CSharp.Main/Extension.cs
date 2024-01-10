



using System.Buffers;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float x, float y) { return x + y; }
        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double x, double y) {  return x + y; }
        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float subtract(float x, float y) { return x - y; }
        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string str, char c) {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if (ch != c)
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int first, int second) { return first * second; }
        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing
        //the provided string as many times as the provided int separated by a comma.
        //E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string str, int frequency) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < frequency; i++)
            {
                sb.Append(str + ",");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int.
        //The method should return an array of ints that contain the value of multiplying each String
        //number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string []array, int num)
        {
            var numArray = new int[num];
            for (int i = 0; i < numArray.Length; i++)
            {
                int current;
                int.TryParse(array[i], out current);
                numArray[i] = current * num;
            }
            
            return numArray;
        }
    }
}
