using NeetCode150.ArraysAndHashing;

namespace NeetCode150
{
    public class Program
    {
        static void Main(string[] args)
        {
            //3. https://neetcode.io/problems/two-integer-sum
            (int[] nums, int target) = TwoSum.GetTestData();
            Console.WriteLine($"[{string.Join(",", TwoSum.Find(nums, target))}]");

            //4. https://neetcode.io/problems/anagram-groups
            var groups = Anagram.GroupAnagrams(Anagram.GetTestData());
            foreach (var str in groups)
            {
                Console.WriteLine(string.Join(", ",str));
            }

            Console.ReadKey();
        }
    }
}
