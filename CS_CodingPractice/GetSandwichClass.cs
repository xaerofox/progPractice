using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    class GetSandwichClass
    {
    /*
    A sandwich is two pieces of bread with something in between.Return the string that is 
    between the first     and last appearance of "bread" in the given string, or return the 
    empty string "" if there are not two pieces of bread.

    getSandwich("breadjambread") → "jam"
    getSandwich("xxbreadjambreadyy") → "jam"
    getSandwich("xxbreadyy") → ""
    */
        public static string getSandwich(string str)
        {
            string result = str;

            result = result.Substring(str.IndexOf("bread") + 5);

            if (result.Contains("bread"))
            {
                int trimEnd = result.IndexOf("bread");
                result = result.Remove(trimEnd);
                return result;
            }
            else
                return "";

        }

        //public static void Main()
        //{
        //    Console.WriteLine(getSandwich("breadjambread"));
        //    Console.WriteLine(getSandwich("xxbreadbloomingjamminbreadyy"));
        //    Console.WriteLine(getSandwich("xxbreadyy"));

        //}
    }
}
