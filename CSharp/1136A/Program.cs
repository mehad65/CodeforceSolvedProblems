namespace CD_1136;

class Program
{
    //https://codeforces.com/problemset/problem/1136/A
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        int[,] num;
        num = new int[input, 2];
        for (int i = 0; i < input; i++)
        {
            string s = Console.ReadLine();
            num[i, 0] = Convert.ToInt32(s.Split(' ')[0]);
            num[i, 1] = Convert.ToInt32(s.Split(' ')[1]);
        }
        int br = 0;
        int k = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < input; i++)
        {
            if (k >= num[i, 0] && k <= num[i, 1])
            {
                br = i;
            }
        }
        Console.WriteLine(input - br);
    }
}
