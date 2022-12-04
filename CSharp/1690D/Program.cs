//https://codeforces.com/problemset/problem/1690/D

var testCase = int.Parse(Console.ReadLine());
for (var tc = 1; tc <= testCase; tc++)
{
    var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    int n = input[0], k = input[1];
    var s = Console.ReadLine();
    var cnt = 0;
    var res = 0;
    for (int i = 0; i < k; i++)
    {
        if (s[i] == 'W')
            cnt++;
    }
    res = cnt;
    for (int i = k; i < n; i++)
    {
        if (s[i] == 'W')
            cnt++;
        if (s[i - k] == 'W')
            cnt--;
        res = Math.Min(res, cnt);
    }
    Console.WriteLine(res);
}

