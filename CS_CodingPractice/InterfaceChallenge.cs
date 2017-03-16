using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    interface IRandomizable
    {
        double GetRandomNum(double upBound); 
    }

    class InterfaceChallenge : IRandomizable
    { 
      public double GetRandomNum(double upBound)
        {
            Random rand = new Random();
            double seed = rand.NextDouble();
            return seed * upBound;
        }
    }
}
