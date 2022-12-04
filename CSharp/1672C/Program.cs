//https://codeforces.com/problemset/problem/1672/C
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    var a = Console.ReadLine().Split().Select(int.Parse).ToList();

    int min = -1;
    int max = -1;
    for (int x = 1; x < n; x++)
    {
        if (a[x] == a[x - 1])
        {
            if (min == -1)
                min = x;
            max = x;
        }
    }

    if (min == max)
        Console.WriteLine(0);
    else
        Console.WriteLine(Math.Max(1, max - min - 1));
}
