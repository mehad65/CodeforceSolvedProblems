//https://codeforces.com/problemset/problem/1671/d

var q = int.Parse(Console.ReadLine());
for (int tc = 1; tc <= q; tc++)
{
    var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    int n = input[0], x = input[1];
    var mas = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    long res = 0;
    int min = mas[0], max = mas[0];
    for (int i = 0; i < n; i++)
    {
        if (i > 0)
            res = res + Math.Abs(mas[i] - mas[i - 1]);
        if (mas[i] < min)
            min = mas[i];
        if (mas[i] > max)
            max = mas[i];
    }
    int l = min - 1;
    int m = x > max ? x - max : 0;
    int mis = int.MaxValue;
    int[] vls = new int[] { mas[0], min, mas[n - 1] };
    int[] vms = new int[] { mas[0], max, mas[n - 1] };
    int[] kfs = new int[] { 1, 2, 1 };
    for (int kl = 0; kl < 3; kl++)
        for (int km = 0; km < 3; km++)
        {
            if (kl == km && kl * km != 1)
                continue;
            var val = 0;
            if (l > 0)
                val += kfs[kl] * (vls[kl] - 1);
            if (m > 0)
                val += kfs[km] * (x - vms[km]);
            if (val < mis)
                mis = val;
        }
    res = res + mis;
    Console.WriteLine(res);
}
