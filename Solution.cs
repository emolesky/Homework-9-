using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeros
{
    internal class Solution
    {
        public void MoveZeros(int[] nums)
        {
            int insertPos = 0;

            for(int i = 0; i< nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[insertPos] = nums[i];
                    insertPos++;
                }
            }
            for(int i = insertPos; i < nums.Length;i++)
            {
                nums[i] = 0;
            }
        }
    }
}
