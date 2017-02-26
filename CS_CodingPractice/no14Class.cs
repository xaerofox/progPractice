using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    /*Given an array of ints, return true if it contains no 1's or it contains no 4's.

    no14([1, 2, 3]) → true
    no14([1, 2, 3, 4]) → false
    no14([2, 3, 4]) → true
    */
    class no14Class
    {
        public static bool no14(int[] nums)
        {
            if (nums.Length == 0) return true;

            if (nums.Contains(1) && nums.Contains(4))
                return false;
            else return true;

        }

        //public static void Main(string[] args)
        //{
        //    int[] sampleOne = { 1, 2, 3 };
        //    int[] sampleTwo = { 1, 2, 3, 4 };
        //    int[] sampleThree = { 2, 3, 4 };
        //    Console.WriteLine( no14(sampleOne) + "\n");
        //    Console.WriteLine(no14(sampleTwo) + "\n");
        //    Console.WriteLine(no14(sampleThree) + "\n");

        //}
    }
}
