namespace LongestSubstringWithoutRepeatingCharacters;

internal class Program
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        Dictionary<char, int> map = new Dictionary<char, int>();
        int maxLength = 0; // ket qua
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            if (map.ContainsKey(c) && map[c] >= left) left = map[c] + 1;

            map[c] = right;

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
    static void Main(string[] args)
    {
        string input = "abcabcbb";
        int result = LengthOfLongestSubstring(input);
        Console.WriteLine($"Độ dài chuỗi con dài nhất không trùng : {result}");

    }
}
