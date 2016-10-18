using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
   /* This is slightly more difficult version of the famous FizzBuzz problem which is sometimes given as a 
    * first problem for job interviews. (See also: FizzBuzz Code.) Consider the series of numbers beginning at start and 
    * running up to but not including end, so for example start = 1 and end = 5 gives the series 1, 2, 3, 4. 
    * Return a new String[] array containing the string form of these numbers, except for multiples of 3, use "Fizz" 
    * instead of the number, for multiples of 5 use "Buzz", and for multiples of both 3 and 5 use "FizzBuzz". 
    * This version is a little more complicated than the usual version since you have to allocate and index into an array instead of just printing, 
    * and we vary the start/end instead of just always doing 1..100. 
    * 
    * fizzBuzz(1, 6) → ["1", "2", "Fizz", "4", "Buzz"]
    * fizzBuzz(1, 8) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7"]
    * fizzBuzz(1, 11) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]
    */

    class FizzBuzzClass
    {
        static void Main(string[] args)
        {
            string[] fbArr;


            fizzBuzzModified(1, 6);
            fizzBuzzModified(1, 8);
            fizzBuzzModified(1, 11);
            

            fbArr = fizzBuzzModified(36, 90);

            for (int i = 0; i < fbArr.Length; i++)
            {
                Console.WriteLine(fbArr[i]);
            }
        }

        public static string[] fizzBuzzModified(int start, int end)
        {
            string[] fbArray = new string[end - start];
            for (int i = 0; i < fbArray.Length; i++)
            {
                if (start % 3 == 0 && start % 5 == 0)
                    fbArray[i] = "FizzBuzz";
                else if (start % 3 == 0)
                    fbArray[i] = "Fizz";
                else if (start % 5 == 0)
                    fbArray[i] = "Buzz";
                else
                    fbArray[i] = start.ToString();

                start++;
            }

            return fbArray;
        }


    }
}
