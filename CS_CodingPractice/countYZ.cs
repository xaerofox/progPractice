using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    class countYZ
    {
        public int countEndYZ(string str)
        {
            int counter = 0;
            str.ToLower();
            while(str.Any())
            {
                if (str[str.Length - 1].Equals('y') || str[str.Length - 1].Equals('z'))
                    counter++;
                if (str.Contains(" "))
                    str = str.Remove(str.LastIndexOf(' '));
                else str = str.Remove(0);
            }

            return counter;
        }
    }
}
