namespace CD_1748A;
class Program
{
    //https://codeforces.com/problemset/problem/1748/A
    public static void Main()
    {
        int testCases = Convert.ToInt32(Console.ReadLine());
        while (testCases-- > 0)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = (n + 1) / 2;
            Console.WriteLine(ans);
        }
    }
}

