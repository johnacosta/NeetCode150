using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArraysAndHashing
{
    /// <summary>
    /// <para>Design an algorithm to encode a list of strings to a single string. 
    /// The encoded string is then decoded back to the original list of strings.
    /// Please implement encode and decode
    /// You may return the output in any order.</para>
    /// <para>Example 1:<br/>
    /// Input: ["neet","code","love","you"]<br/>
    /// Output: ["neet","code","love","you"]</para>
    /// <para>Example 2:<br/>
    /// Input: ["we","say",":","yes"]<br/>
    /// Output: ["we","say",":","yes"]</para>
    /// <see href="https://neetcode.io/problems/string-encode-and-decode"/>
    /// </summary>
    public class EncodeDecode
    {
        public static string Encode(IList<string> strs)
        {
            string result = "";

            //append the length of the string and our delimiter '#'
            foreach (string s in strs)
            {
                result += s.Length + "#" + s;
            }

            return result;
        }

        public static List<string> Decode(string s)
        {
            var result = new List<string>();
            int i = 0;
            while (i < s.Length)
            {
                // j is used as a ptr to iterate up to our delimiter '#'
                int j = i;
                while (s[j] != '#')
                {
                    j++;
                }

                //Parse the meta-data containing the length of the substring we need to extract
                int length = int.Parse(s.Substring(i, j - i));

                //this is where the string we need to decode begins
                i = j + 1;

                //extract the substring and add to the list
                result.Add(s.Substring(i, length));

                //this is where the next string begins 
                j = i + length;

                //set i to the start of the next meta-data containing the length of the next string we need to extract
                i = j;
            }

            return result;
        }

        public static List<string> GetTestData() => new List<string>() { "neet", "code", "love", "you" };
    }
}
