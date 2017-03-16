using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    class Driver
    {
        public static void Main()
        {
            /* The following comes from Lynda.com - C# Interfaces and Generics.  The challenge is Building a random number generator using an interface. */
            InterfaceChallenge randNumber = new InterfaceChallenge();
            string str;

            do
            {
                Console.Write("Enter a number for the upper bound:");
                str = Console.ReadLine();
                try
                {
                    double upperBound = Double.Parse(str);
                    Console.WriteLine("\nRandom number between 0 and " + upperBound + ": " 
                        + randNumber.GetRandomNum(upperBound));
                }
                catch (Exception e) { }
            } while (str != "exit");

            /* ------------------------------------------------------------------------------------------------------------------------------------------*/

            //CanBalance canBal = new CanBalance();
            //int[] nums = { -15,20,-30,-5,-1 };

            //Console.WriteLine(canBal.canBalance(nums));

            //countYZ countYZObj = new countYZ();

            //Console.WriteLine(countYZObj.countEndYZ("fez day"));
            //Console.WriteLine(countYZObj.countEndYZ("day fez"));
            //Console.WriteLine(countYZObj.countEndYZ("day fyyz"));
            //Console.WriteLine(countYZObj.countEndYZ("day fyyz froo7 god ez"));



            //gHappy gHappyObject = new gHappy();

            //Console.WriteLine(gHappyObject.gIsHappy("xxggxx"));
            //Console.WriteLine(gHappyObject.gIsHappy("g"));
            //Console.WriteLine(gHappyObject.gIsHappy("xxggyygxx"));





        }
    }
}
