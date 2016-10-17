using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    /*
     * Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, 
     * or whatever is there if the string is less than length 3. Return n copies of the front;
     * 
     * frontTimes("Chocolate", 2) → "ChoCho"
     * frontTimes("Chocolate", 3) → "ChoChoCho"
     * frontTimes("Abc", 3) → "AbcAbcAbc"
    */


    class frontTimesClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(frontTimes("Chocolate", 2));
            Console.WriteLine(frontTimes("Something", 4));
            Console.WriteLine(frontTimes("HI", 5));
        }

        public static string frontTimes(string str, int n)
        {
            string result = "";
            if (str.Length < 3)
            {
                for (int i = 0; i < n; i++)
                {
                    result = result + str;
                }
                return result;
            }
            else
            {
                string sub = str.Substring(0, 3);
                for (int i = 0; i < n; i++)
                {
                    result += sub;
                }
                return result;
            }
        }
    }
}
