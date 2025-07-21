using System.Text.RegularExpressions;

namespace ReadmeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = Directory.GetCurrentDirectory(); // Thư mục hiện tại

            // Danh sách folder cần bỏ qua
            var excludedFolders = new[] { ".git", ".vs", "bin", "obj" };

            var folders = Directory.GetDirectories(rootPath)
                .Select(Path.GetFileName)
                .Where(name => !string.IsNullOrWhiteSpace(name) && !excludedFolders.Contains(name))
                .OrderBy(name => name)
                .ToList();

            using var writer = new StreamWriter("README.md");

            writer.WriteLine("# 🧠 Giải LeetCode bằng C# ");
            writer.WriteLine();
            writer.WriteLine("Repo này tổng hợp các bài LeetCode đã giải bằng **C#**.");
            writer.WriteLine("Mỗi thư mục tương ứng với một bài.\n");
            writer.WriteLine("## 📌 Danh sách bài đã làm\n");

            for (int i = 0; i < folders.Count; i++)
            {
                string folderName = folders[i];
                string readableName = Regex.Replace(folderName, "(\\B[A-Z])", " $1");
                writer.WriteLine($"- [x] {i + 1}. {readableName}");
            }

            Console.WriteLine("✅ README.md đã được tạo lại.");
        }
    }
}
