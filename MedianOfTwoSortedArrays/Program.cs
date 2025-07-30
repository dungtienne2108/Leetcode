namespace MedianOfTwoSortedArrays
{
    internal class Program
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);

            int x = nums1.Length;
            int y = nums2.Length;

            int left = 0, right = x;

            while (left <= right)
            {
                int pX = (left + right) / 2;
                int pY = (x + y + 1) / 2 - pX;

                int maxLeftX = (pX == 0) ? int.MinValue : nums1[pX - 1];
                int minRightX = (pX == x) ? int.MaxValue : nums1[pX];

                int maxLeftY = (pY == 0) ? int.MinValue : nums2[pY - 1];
                int minRightY = (pY == y) ? int.MaxValue : nums2[pY];

                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    if ((x + y) % 2 == 0)
                    {
                        return ((double)Math.Max(maxLeftY, maxLeftX) + Math.Min(minRightX, minRightY)) / 2;
                    }
                    else
                    {
                        return (double)Math.Max(maxLeftX, maxLeftY);
                    }
                }
                else if (maxLeftX > minRightY)
                {
                    right = pX - 1;
                }
                else
                {
                    left = pX + 1;
                }
            }

            return -1.0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
