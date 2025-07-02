namespace TwoSum
{
    internal class Program
    {


        public static int[] TwoSum(int[] nums, int target)
        {
            int n = nums.Length;
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                var currentNumber = nums[i];
                var complement = target - currentNumber;
                if (dictionary.ContainsKey(complement))
                {
                    var complementIndex = dictionary[complement];
                    return new int[] { complementIndex, i };
                }
                dictionary[currentNumber] = i;
            }
            return new int[]
            {
                -1,-1
            };
        }

        static void Main(string[] args)
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = TwoSum(nums, target);
            Console.WriteLine(result[0] + " " + result[1]);
        }
    }
}
