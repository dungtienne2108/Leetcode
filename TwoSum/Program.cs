﻿namespace TwoSum
{
    internal class Program
    {
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[]
            {
                -1,-1
            };
        }

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
            // var result = TwoSumBruteForce(nums, target);
            Console.WriteLine(result[0] + " " + result[1]);
        }
    }
}
