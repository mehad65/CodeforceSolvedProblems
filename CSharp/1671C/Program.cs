//https://codeforces.com/problemset/problem/1671/C

var testCase = int.Parse(Console.ReadLine().Trim());
while (testCase-- > 0)
{
    string[] line = Console.ReadLine().Trim().Split(' ');
    var n = int.Parse(line[0]);
    var x = int.Parse(line[1]);

    line = Console.ReadLine().Trim().Split(' ');
    var a = Array.ConvertAll(line, int.Parse);
    getAns(n, x, a);
}

static void getAns(int n, int x, int[] a)
{
    Array.Sort(a);
    var b = new long[n];
    b[0] = a[0];
    for (int i = 1; i < n; i++) b[i] = b[i - 1] + a[i];
    var ans = 0L;
    for (int i = 0; i < n; i++)
    {
        var t = (x - b[i] + i + 1) / (i + 1);
        if (t >= 1) ans += t;
        else break;
    }
    Console.WriteLine(ans);
}