



using System.Reflection.Metadata.Ecma335;

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
        {
            return a + b;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float subtract(float a, float b)
        {
            return a - b;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string str, char chr)
        {
            string result = "";
            foreach (char c in str)
            {
                if (c != chr)
                {
                    result += c;
                }
            }

            return result;
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int a, int b)
        {
            return a * b;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string str, int i)
        {
            string answer = "";
            for (int j = 0; j < i; j++)
            {
                if (answer.Length > 0)
                {
                    answer += ",";
                }
                answer += str;
              
            }

          

            return answer;
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] stringArray, int factor)
        {
            
            int[] result = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                string numstr = stringArray[i];
                int num = int.Parse(numstr) * factor;
                result[i] = num;

            }
            return result;
        }
     
    }
}
