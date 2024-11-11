﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArraysAndHashing
{
    public class TopKFrequent
    {
        public static int[] Find(int[] nums, int k)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            List<int>[] freq = new List<int>[nums.Length + 1];
            for (int i = 0; i < freq.Length; i++)
            {
                freq[i] = new List<int>();
            }

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
            foreach (var entry in count)
            {
                freq[entry.Value].Add(entry.Key);
            }

            int[] res = new int[k];
            int index = 0;
            for (int i = freq.Length - 1; i > 0 && index < k; i--)
            {
                foreach (int n in freq[i])
                {
                    res[index++] = n;
                    if (index == k)
                    {
                        return res;
                    }
                }
            }
            return res;
        }

        public static (int[], int) GetTestData() => (new int[] { 1, 2, 2, 3, 3, 3 }, 2);
    }
}