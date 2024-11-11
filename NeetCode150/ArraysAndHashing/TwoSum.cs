using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArraysAndHashing
{
    //3. https://neetcode.io/problems/two-integer-sum
    public class TwoSum
    {
        public static int[] Find(int[] nums, int target)
        {

            // key = complement value = index
            var comps = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement
                var complement = target - nums[i];

                // Check to see if complement exists
                if (comps.ContainsKey(complement))
                {
                    return new[] { comps[complement], i };
                }

                // else add the number and index
                comps.Add(nums[i], i);
            }

            return new[] { 0, 1 };
        }

        public static (int[], int) GetTestData() => (new int[] { 3, 4, 5, 6 }, 7);
    }
}
