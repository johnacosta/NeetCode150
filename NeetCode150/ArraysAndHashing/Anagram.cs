using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArraysAndHashing
{
    //4. https://neetcode.io/problems/anagram-groups
    internal static class Anagram
    {
        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            // key = mapping of chars, value = list of grouped anagrams
            var res = new Dictionary<string, List<string>>();

            // loop through each of the strings in the array
            foreach (var s in strs)
            {
                // char array to count the number of times a char appear in a string
                int[] count = new int[26];

                //loop through each char in the string
                foreach (char c in s)
                {
                    // map the char to a zero based index and increment count
                    count[c - 'a']++;
                }

                //creat a comma-separated string representing the count
                string key = string.Join(",", count);

                //if the the key doesnt exist create a new list as the value
                if (!res.ContainsKey(key))
                {
                    res[key] = new List<string>();
                }

                //add the string to the list under the value to form the anagram groups
                res[key].Add(s);
            }

            //return the values (grouped anagrams) as a list
            return res.Values.ToList();
        }

        public static string[] GetTestData() => new[] { "act", "pots", "tops", "cat", "stop", "hat" };

    }
}
