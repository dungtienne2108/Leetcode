namespace BinarySearch
{
    internal class Program
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target) return mid;
                else if (nums[mid] < target) left = mid + 1;
                else right = mid - 1;
            }

            return -1;

        }

        public static int Search(int[] nums, int left, int right, int target)
        {
            if (left > right) return -1;

            int mid = (left + right) / 2;

            if (nums[mid] == target) return mid;
            else if (nums[mid] < target) return Search(nums, mid + 1, right, target);
            else return Search(nums, left, mid - 1, target);
        }

        static void Main(string[] args)
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = ;
            int result = Search(nums, 0, nums.Length - 1, target);
            if (result != -1)
            {
                Console.WriteLine($"Tìm thấy {target} tại vị trí {result}.");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy {target} trong mảng.");
            }
        }
    }
}
