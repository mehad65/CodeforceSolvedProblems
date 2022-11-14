namespace CD_1270A;

class Program
{
    //https://codeforces.com/problemset/problem/1270/A
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        while (t-- > 0)
        {
            int maxFirst = -1;
            int maxSecond = -1;
            string input = Console.ReadLine();
            input = Console.ReadLine();
            foreach (var x in input.Split(' '))
            {
                if (Convert.ToInt32(x) > maxFirst) maxFirst = Convert.ToInt32(x);
            }
            input = Console.ReadLine();
            foreach (var x in input.Split(' '))
            {
                if (Convert.ToInt32(x) > maxSecond) maxSecond = Convert.ToInt32(x);
            }
            Console.WriteLine(maxFirst > maxSecond ? "YES" : "NO");
        }
    }
}
