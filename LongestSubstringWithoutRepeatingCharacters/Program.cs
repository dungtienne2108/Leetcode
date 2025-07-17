namespace LongestSubstringWithoutRepeatingCharacters;

internal class Program
{
    public static int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            if (map.ContainsKey(c) && map[c] >= left)
            {
                // nếu đã xuất hiện trong cửa sổ hiện tại -> cập nhật left
                left = map[c] + 1;
            }

            // cập nhật hoặc thêm mới vào map
            map[c] = right;

            // cập nhật maxlenght
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
    static void Main(string[] args)
    {
        string input = "abcabcbb";
        int result = LengthOfLongestSubstring(input);
        Console.WriteLine($"Chuỗi con dài nhất không trùng có độ dài : {result}");

    }
}
