using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArraysAndHashing
{
    /// <summary>
    /// <para>Given an array of integers nums, return the length of the longest consecutive sequence of elements that can be formed.
    /// A consecutive sequence is a sequence of elements in which each element is exactly 1 greater than the previous element. The elements do not have to be consecutive in the original array.
    ///You must write an algorithm that runs in O(n) time.</para>
    /// <para>Example 1:<br/>
    /// Input: nums = [2,20,4,10,3,4,5]<br/>
    /// Output: 4<br/>
    /// Explanation: The longest consecutive sequence is [2, 3, 4, 5].</para>
    /// <para>Example 2:<br/>
    /// Input: nums = [0,3,2,5,4,6,1,1]<br/>
    /// Output: 7</para>
    /// <see href="https://neetcode.io/problems/longest-consecutive-sequence"/>
    /// </summary>
    internal class LongestConsecutiveSequence
    {
        public static int Find(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in numSet)
            {
                // if it doesnt contain the number before it, it is the start of a sequence
                if (!numSet.Contains(num - 1))
                {
                    int length = 1;
                    //
                    while (numSet.Contains(num + length))
                    {
                        length++;
                    }
                    longest = Math.Max(longest, length);
                }
            }
            return longest;
        }

        public static int[] GetTestData() => new int[] { 2, 20, 4, 10, 3, 4, 5 };
    }
}
