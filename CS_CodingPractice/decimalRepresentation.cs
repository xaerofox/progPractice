using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    // Find the # of decimal places to a number
    // EX: findDecNum(3.14) => 2
    // EX: findDecNum(3.3458349573) => 10


    class DecimalRepresentation
    {
        /*static void Main(string[] args)
        {
            
            string answer;

            do
            {
                double userInput = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(findDecNum(userInput));

                Console.WriteLine("Try Again? (y/n)");
                answer = Console.ReadLine();
            } while (answer == "y" || answer == "yes");
        }*/

        public static int FindDecNum(double val)
        {
            int i = 0;
            if (val != 0)
            {
                while (Math.Round(val, i) != val)
                {
                    var showCurrent = Convert.ToString(Math.Round(val, i));
                    i++;
                }
                return i;
            }
            else return i;
        }
    }
}
