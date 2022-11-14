namespace CD_1139A;

class Program
{
    //https://codeforces.com/problemset/problem/1139/A
    static void Main()
    {
        var n = int.Parse(Console.ReadLine().Trim());
        var s = Console.ReadLine().Trim();
        GetResult(n, s);
    }
    static void GetResult(int n, string s)
    {
        var ans = 0L;
        for (int i = 0; i < n; i++)
        {
            if ((s[i] - '0') % 2 == 0) ans += i + 1;
        }
        Console.WriteLine(ans);
    }
}
