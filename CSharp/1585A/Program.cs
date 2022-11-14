namespace CD_1585A
{
    public class Program
    {
        //https://codeforces.com/problemset/problem/1585/A
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

                int size = 1;
                size += a[0];
                bool isBig = false;

                for (int j = 1; j < a.Length; j++)
                {
                    if (a[j] == 0 && a[j - 1] == 0)
                    {
                        isBig = true;
                        break;
                    }
                    else if (a[j] == 0)
                        continue;
                    else if (a[j] == 1 && a[j - 1] == 0)
                        size++;
                    else
                        size += 5;
                }

                if (isBig)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(size);
                }
            }
        }
    }
}
