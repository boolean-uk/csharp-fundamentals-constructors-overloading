



using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float number1, float number2)
        {
            return number1 + number2;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double number1, double number2)
        {
            return number1 + number2;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float subtract(float number1, float number2)
        {
            return number1 - number2;
        }
        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed        
        public string subtract(string string1, char char1) 
        {
            StringBuilder stringbuilder = new StringBuilder();
            
            foreach (char c in string1)
            {
                if (c != char1)
                {
                    stringbuilder.Append(c);
                }
            }
            return stringbuilder.ToString();
        }
        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string string1, int number1) 
        {
            StringBuilder stringbuilder = new StringBuilder();

            for (int i= 0; i < number1; i++)
            {
                stringbuilder.Append(string1);

                if (i < number1 - 1)
                {
                    stringbuilder.Append(",");
                }
            
            }
            return stringbuilder.ToString();
        }
      
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] stringNumbers, int multiplier) 
        {
            int[] resultArray = new int[stringNumbers.Length];

            for (int i= 0;i < stringNumbers.Length; i++)
            {
                int numberToMutiply = int.Parse(stringNumbers[i]);
                resultArray[i] = numberToMutiply * multiplier;
            }
            return resultArray;
        }
        
    }
}
