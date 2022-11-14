namespace CD_1443A;
class Program
{
    //https://codeforces.com/problemset/problem/1443/A
    static void Main()
    {
        var t = int.Parse(Console.ReadLine().Trim());
        while (t-- > 0)
        {
            var n = int.Parse(Console.ReadLine().Trim());
            GetResult(n);
        }
    }
    static void GetResult(int n)
    {
        var ans = new List<int>();
        var n4 = n * 4;
        for (int i = 0; i < n; i++)
        {
            ans.Add(n4 - 2 * i);
        }
        Console.WriteLine(string.Join(" ", ans));
    }
}

