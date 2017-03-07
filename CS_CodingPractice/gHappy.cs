using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    class gHappy
    {
        public bool gIsHappy(string str)
        {
            if (str.Length < 2) return false;
            else
            {
                while (str.Contains('g'))
                {
                    int x = str.IndexOf('g');
                    if (str[x + 1].Equals('g'))
                    {
                        str = str.Remove(0, x+2);
                    }
                    else return false;
                }

                return true;
            }
        }
    }
}
