namespace RomanToInt
{
    internal class Program
    {
        public static int RomanToInt(string s)
        {
            var romanToIntMap = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int total = 0;
            int prevValue = 0;
            int n = s.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                char currentChar = s[i];
                int currentValue = romanToIntMap[currentChar];
                if (currentValue < prevValue)
                {
                    total -= currentValue;
                }
                else
                {
                    total += currentValue;
                }
                prevValue = currentValue;
            }
            return total;

        }

        static void Main(string[] args)
        {
            string s = "LVIII";
            int result = RomanToInt(s);
            Console.WriteLine($"Số {s} sau khi chuyển đổi là: {result}");
        }
    }
}
