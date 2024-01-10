namespace Boolean.CSharp.Main
{
    public class Extension
    {

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)

        public float add(float v1, float v2)
        {
            return v1 + v2;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double v1, double v2)
        {
            return v1 + v2;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float subtract(float v1, float v2)
        {
            return v1 - v2;
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        public string subtract(string s, char c)
        {
            return s.Replace(c.ToString(), "");
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string s, int v)
        {
            string outString = "";
            for (int i = 0; i < v; i++)
            {
                if (i == v - 1)
                {
                    outString += s;
                }
                else
                {
                    outString += (s + ",");
                }
            }
            return outString;
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] sL, int v)
        {
            int[] result = new int[sL.Length];
            for (int i = 0; i < sL.Length; i++)
            {
                int converted;
                try
                {
                    converted = Int32.Parse(sL[i]);
                    result[i] = converted * v;
                }
                catch { }
            }
            return result;
        }
    }
}
