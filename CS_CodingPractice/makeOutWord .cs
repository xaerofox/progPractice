using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
/* 
 * Given an "out" string length 4, such as "<<>>", and a word, return a new string where the word is in the middle of the 
 * out string, e.g. "<<word>>". Note: use str.substring(i, j) to extract the String starting at index i and going up to but 
 * not including index j .
 * 
 * 
 * makeOutWord("<<>>", "Yay") → "<<Yay>>"
 * makeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"
 * makeOutWord("[[]]", "word") → "[[word]]"
 */
    class makeOutWordClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(makeOutWord("<<>>", "yay"));
            Console.WriteLine(makeOutWord("<<>>", "WooHoo"));
            Console.WriteLine(makeOutWord("[[]]", "word"));
            Console.WriteLine(makeOutWord("racecar", "word"));
        }

        public static string makeOutWord(string o, string word)
        {
            if (o.Length >= 4)
                return o.Insert(o.Length / 2, word);
            else
                return "Out value is less than 4.";
        }
    }
}
