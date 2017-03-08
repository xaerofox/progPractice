using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_CodingPractice
{
    class CanBalance
    {
        public bool canBalance(int[] nums)
        {
            int leftSum = 0;
            int rightSum = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                leftSum += nums[i];
                rightSum -= nums[i];

                if (leftSum == rightSum) return true;
            }

            return false;
        }
        
    }
}
