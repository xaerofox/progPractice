﻿using System;
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
            countYZ countYZObj = new countYZ();

            Console.WriteLine(countYZObj.countEndYZ("fez day"));
            Console.WriteLine(countYZObj.countEndYZ("day fez"));
            Console.WriteLine(countYZObj.countEndYZ("day fyyz"));
            Console.WriteLine(countYZObj.countEndYZ("day fyyz froo7 god ez"));



            //gHappy gHappyObject = new gHappy();

            //Console.WriteLine(gHappyObject.gIsHappy("xxggxx"));
            //Console.WriteLine(gHappyObject.gIsHappy("g"));
            //Console.WriteLine(gHappyObject.gIsHappy("xxggyygxx"));

        }
    }
}