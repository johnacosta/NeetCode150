using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace NeetCode150.ArraysAndHashing
{
    /// <summary>
    /// <para>Given an integer array nums and an integer k, return the k most frequent elements within the array.
    /// The test cases are generated such that the answer is always unique.
    /// You may return the output in any order.</para>
    /// <para>Example 1:<br/>
    /// Input: nums = [1,2,2,3,3,3], k = 2<br/>
    /// Output: [2,3]</para>
    /// <para>Example 2:<br/>
    /// Input: nums = [7,7], k = 1<br/>
    /// Output: [7]</para>
    /// <see href="https://neetcode.io/problems/top-k-elements-in-list"/>
    /// </summary>
    public class TopKFrequent
    {
        public static int[] Find(int[] nums, int k)
        {
            //dictionary to count each element in input array nums
            Dictionary<int, int> count = new Dictionary<int, int>();

            //array of lists to store frequency of each element in input array nums
            //key will be the index and value will be a list of elements that pertain to a specific count
            List<int>[] freq = new List<int>[nums.Length + 1];

            //populate the frequency array with empty lists
            for (int i = 0; i < freq.Length; i++)
            {
                freq[i] = new List<int>();
            }

            //Populate and add counts for each occurence of integers in the nums input array
            //End of loop: count = { [1,1], [2,2], [3,3] }
            foreach (int n in nums)
            {
                if (count.ContainsKey(n))
                {
                    count[n]++;
                }
                else
                {
                    count[n] = 1;
                }
            }

            //for each entry in the count dictionary swap the key for the value in the frequency array of lists
            //End of loop: [ { {0}, {1}, {2}, {3}, {0} {0}, {0} } ]
            foreach (var entry in count)
            {
                freq[entry.Value].Add(entry.Key);
            }

            int[] result = new int[k];
            int index = 0; //keep track of the amount of elements we are adding to the results array
            //loop through the frequency array in descending order and and store the top k elements
            for (int i = freq.Length - 1; i > 0 && index < k; i--)
            {
                //loop through the lists within the frequency array
                foreach (int n in freq[i])
                {
                    //insert the element into results array
                    result[index++] = n;

                    // return results array once we've added k elements
                    if (index == k)
                    {
                        return result;
                    }
                }
            }
            return result;
        }

        public static (int[], int) GetTestData() => (new int[] { 1, 2, 2, 3, 3, 3, 4,4,4 }, 2);
    }
}
