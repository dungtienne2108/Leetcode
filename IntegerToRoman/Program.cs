using System.Text;

namespace IntegerToRoman;

internal class Program
{
    public static string IntToRoman(int num)
    {
        var romanValue = new (int value, string numeral)[]
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };
        var result = new StringBuilder(); // trong C# thì string nó là bất biến
        foreach (var pair in romanValue)
        {
            while (num >= pair.value) // -> tham lam -> dùng giá trị hiện tại nhiều nhất có thể
            {
                result.Append(pair.numeral);
                num -= pair.value;
            }
        }
        return result.ToString();
    }

    static void Main(string[] args)
    {
        int n = 2004;
        Console.WriteLine($"Integer : {n} -> Roman : {IntToRoman(n)}");
    }
}
