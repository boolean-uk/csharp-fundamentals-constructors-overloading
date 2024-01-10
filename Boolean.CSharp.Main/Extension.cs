



using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)

        public float add(float one, float two)
        {
            return one + two;  
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double one, double two)
        {
            return one + two;
        }
        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float subtract(float one, float two)
        {
            return one - two;
        }
        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string str, char ch)
        {
            return str.Replace(ch.ToString(),"");
        }
        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int one, int two)
        {
            return one * two;
        }
        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string str, int num)
        {
            string end = str;
            for(int i = 1; i < num; i++)
            {
                end = end + "," + str;
            }
            return end;
        }
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] str,  int num)
        {
            int[] result = new int[str.Length];
            for(int i = 0; i < str.Length;i++)
            {
                try
                {
                    result[i] = int.Parse(str[i]) * num;
                }catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

            return result;
        }
    }
}
