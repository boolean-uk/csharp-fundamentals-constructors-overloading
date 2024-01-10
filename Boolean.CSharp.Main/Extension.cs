



using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float num1, float num2)
        {
            return num1 + num2;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)

        public double add(double num1, double num2)
        {
            return num1 + num2;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string line, char c)
        {
            return line.Replace($"{c}", "");
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string line, int num)
        {
            string output = line + ",";
            for (int i = 1; i < num-1; i++)
            {
                output += line + ",";
            }

            output += line;

            return output;
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] lines, int num)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < lines.Length; i++)
            {
                int currNum = int.Parse(lines[i]);
                output.Add(currNum * num);
            }

            return output.ToArray();
        }
    }
}
