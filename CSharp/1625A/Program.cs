namespace CD_1625A;
class _1625A
{
    //https://codeforces.com/problemset/problem/1625/A
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        while (t-- != 0)
        {
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int answer = 0;
            for (int i = 0; i < inputArray[1]; i++)
            {
                int c0 = 0, c1 = 0;
                for (int j = 0; j < inputArray[0]; j++)
                {
                    int dig = numbers[j] & 1;
                    numbers[j] >>= 1;
                    if (dig == 0)
                        c0++;
                    else
                        c1++;
                }
                if (c1 > c0)
                    answer += (int)Math.Pow(2, i);
            }
            Console.WriteLine(answer);
        }
    }
}