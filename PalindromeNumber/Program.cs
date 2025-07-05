namespace PalindromeNumber;

internal class Program
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        var reverse = 0;
        int n = x;
        while (n != 0)
        {
            var tmp = n % 10;
            reverse = reverse * 10 + tmp;
            n /= 10;
        }
        return reverse == x;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Nhập một số nguyên: ");
        int x;
        while (!int.TryParse(Console.ReadLine(), out x) || x < 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ: ");
        }
        bool result = IsPalindrome(x);
        if (result)
        {
            Console.WriteLine($"Số {x} là một số Palindrome.");
        }
        else
        {
            Console.WriteLine($"Số {x} không phải là một số Palindrome.");
        }
    }
}