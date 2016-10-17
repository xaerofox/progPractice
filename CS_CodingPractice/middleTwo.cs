using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    /*
     * Given a string of even length, return a string made of the middle two chars, so the string "string" yields "ri". 
     * The string length will be at least 2. 
     * 
     * 
     * middleTwo("string") → "ri"
     * middleTwo("code") → "od"
     * middleTwo("Practice") → "ct" 
     */
    class middleTwoClass
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine(middleTwo("string"));
            Console.WriteLine(middleTwo("code"));
            Console.WriteLine(middleTwo("Practice"));
            Console.WriteLine(middleTwo("blahHah"));

        }*/

        public static string middleTwo(string str)
        {
            if (str.Length % 2 == 0 && str.Length >= 2)
                return str.Substring((str.Length / 2) - 1, 2);
            else
                return "String too short, sorry";
        }
    }
}
