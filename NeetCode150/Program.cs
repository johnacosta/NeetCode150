using NeetCode150.ArraysAndHashing;

namespace NeetCode150
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------------*/
            (int[] nums, int target) = TwoSum.GetTestData();
            Console.WriteLine($"[{string.Join(",", TwoSum.Find(nums, target))}]");
            
            /*------------------------------------------*/
            var groups = Anagram.GroupAnagrams(Anagram.GetTestData());
            foreach (var str in groups)
            {
                Console.WriteLine(string.Join(", ",str));
            }
            
            /*------------------------------------------*/
            (nums, int k) = TopKFrequent.GetTestData();
            var topKFrequent = TopKFrequent.Find(nums, k);

            /*------------------------------------------*/
            Console.ReadKey();
        }
    }
}
