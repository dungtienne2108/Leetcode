namespace ContainerWithMostWater
{
    internal class Program
    {
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0; // dau
            int right = height.Length - 1; // cuoi

            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int width = right - left;

                int area = minHeight * width;

                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }


        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int maxArea = MaxArea(height);
            Console.WriteLine($"Thể tích lớn nhất có thể chứa là: {maxArea}");
        }
    }
}
