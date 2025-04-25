using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority
{
    internal class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int s = 0;
            foreach(int num in nums)
            {
                if (count==0)
                {
                    s = num;
                }
                count += (num == s) ? 1 : -1;

            }
            return s;
        }
    }
}
