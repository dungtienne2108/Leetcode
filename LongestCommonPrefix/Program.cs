namespace LongestCommonPrefix
{
    internal class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1); // cắt từ 0 và cắt prefix.leng -1 phần tử
                    if (prefix == "") return "";
                }
            }
            return prefix;

        }
        static void Main(string[] args)
        {
            string[] strs = { "dog", "racecar", "car" };
            string result = LongestCommonPrefix(strs);
            Console.WriteLine($"Chuỗi chung dài nhất là: {result}");
        }
    }
}
