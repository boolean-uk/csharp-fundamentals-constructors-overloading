



using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add (float value1, float value2)
            { 
            return value1 + value2; 
        } 

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add (double value1, double value2)
        {
            return value1 + value2;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)      
        public float substract(float value1, float value2)
        {
                return value1 - value2;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        public string substract(string string1, char char1)
        {
            // what method to use to remove the char from the given string input.
            // create a new StringBuilder
            StringBuilder sb = new StringBuilder();
            foreach(char character in string1)
            {
                if(character != char1)
                {
                    sb.Append(character);
                }
            }
                return sb.ToString();

            //throw new NotImplementedException();

            //return value1 - value2;
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply (int value1, int value2)
        {
            return value1 * value2;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string
        //as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
      public string Multiply(string strWord, int multiplier) {
            
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < multiplier; i++) {
                sb.Append("Hello,");
            }
            string result = sb.ToString();
            //throw new NotImplementedException();
            // repeat the string in the given int value input
            // remove the comma before returning
            return result.Remove(result.Length - 1);
        }
        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int.
        //The method should return an array of ints that contain the value of multiplying each String number by the provided int
        //E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply (string[] strNumber, int multiplier)
        {
            // string Array parse to int. 
            // for loop -> in 

            int[] result = new int[strNumber.Length];
            for(int i = 0; i < strNumber.Length ; i++)
            {
                //int value2 = int.Parse(value2[i]);
                // the index of the new array result[i] is the int index of the Parsed string[] source[i] 
                // multiplied with the int multiplier
                int strNumberToMultiply = int.Parse(strNumber[i]);
                result[i] = strNumberToMultiply * multiplier;
      
            }
            return result;
        }
    }
}
