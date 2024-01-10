



using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float val1, float val2)
        {
            return(val1 + val2);
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double val1, double val2)
        {
            return(val1 + val2);
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float subtract(float val1, float val2)
        {
            return (val1 - val2);
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        public string subtract(string input, char c)
        {
            if (input.Contains(c)) {
             
                 return input.Replace(c.ToString(), "");
            }

            return input;
         
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int val1, int val2)
        {
            return(val1 * val2);
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string input, int n)
        {
            //3
            string ans = "";
            // i ska var mindre enn 3
            //0, 1, 2
            //
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    ans += input;
                } else { 
                ans += input + ",";
            }
               
            }
            return ans;
        }
      
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] strArray, int n)
        {
            int[] result = new int[strArray.Length];
            for(int i = 0;i < strArray.Length;i++)
            {
                result[i] = int.Parse(strArray[i]) * n;
            }

            return result;
        }
    }
}
