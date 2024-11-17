using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArraysAndHashing
{
    /// <summary>
    /// <para>Given an integer array nums, return an array output where output[i] is the product of all the elements of nums except nums[i].
    /// Each product is guaranteed to fit in a 32-bit integer.
    /// Follow-up: Could you solve it in O(n) time without using the division operation?</para>
    /// <para>Example 1:<br/>
    /// Input: nums = [1,2,4,6]<br/>
    /// Output: [48,24,12,8]</para>
    /// <para>Example 2:<br/>
    /// Input: nums = [-1,0,1,2,3]<br/>
    /// Output: [0,-6,0,0,0]</para>
    /// <see href="https://neetcode.io/problems/products-of-array-discluding-self"/>
    /// </summary>
    public class ProductArrayExceptSelf
    {
        // Brute Force Time-complexity: O(n^2)
        public static int[] FindN2(int[] nums)
        {
            var output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var product = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        product *= nums[j];
                    }
                }
                output[i] = product;
            }

            return output;

        }

        //Time-complexity: O(n)
        public static int[] Find(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];
            int[] pref = new int[n];
            int[] suff = new int[n];

            pref[0] = 1;
            suff[n - 1] = 1;
            for (int i = 1; i < n; i++)
            {
                pref[i] = nums[i - 1] * pref[i - 1];
            }
            for (int i = n - 2; i >= 0; i--)
            {
                suff[i] = nums[i + 1] * suff[i + 1];
            }
            for (int i = 0; i < n; i++)
            {
                res[i] = pref[i] * suff[i];
            }
            return res;
        }

        public static int[] GetTestData() => new int[] { 1, 2, 4, 6 };
    }
}
