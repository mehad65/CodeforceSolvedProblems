using System.Text;

namespace CD_1459A;

class Program
{
    //https://codeforces.com/problemset/problem/1459/A
    public static void Main()
    {
        var results = new StringBuilder();
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++)
            results.AppendLine(Solve());
        Console.WriteLine(results);
    }

    static string Solve()
    {
        var n = int.Parse(Console.ReadLine());
        var r = Console.ReadLine();
        var b = Console.ReadLine();

        var result = 0;
        for (var i = 0; i < n; i++)
            result += Math.Sign(r[i] - b[i]);

        return result > 0 ? "RED" : (result < 0 ? "BLUE" : "EQUAL");
    }
}
