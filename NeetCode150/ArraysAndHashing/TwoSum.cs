using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArraysAndHashing
{
    /// <summary>
    /// <para>Given an array of integers nums and an integer target, return the indices i and j 
    /// such that nums[i] + nums[j] == target and i != j.
    /// You may assume that every input has exactly one pair of indices i and j that satisfy the condition.
    /// Return the answer with the smaller index first.</para>
    /// <para>Example 1:<br/>
    /// Input: nums = [3,4,5,6], target = 7<br/>
    /// Output: [0,1]</para>
    /// <para>Example 2:<br/>
    /// Input: nums = [4,5,6], target = 10<br/>
    /// Output: [0,2]</para>
    /// <para>Example 3:<br/>
    /// Input: nums = [5,5], target = 10<br/>
    /// Output: [0,1]</para>
    /// <see href="https://neetcode.io/problems/two-integer-sum"/>
    /// </summary>
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
