namespace CD_1672D
{
    class Program
    {
        //https://codeforces.com/problemset/problem/1672/D
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < input; k++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];
                a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                int[] b = new int[n];
                b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                int[] c = new int[n + 1];
                for (int iq = 0; iq < n + 1; iq++) c[iq] = 0;
                int i = 0, j = 0, flag = 1;
                while (i < n || j < n)
                {
                    if (j < n - 1 && b[j] == b[j + 1] && c[b[j]] > 0)
                    {
                        c[b[j]]--;
                        j++;
                    }
                    else if (i < n && j < n && a[i] == b[j])
                    {
                        i++; j++;
                    }
                    else if (i < n)
                    {
                        c[a[i]]++;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        flag = 0; break;
                    }
                }
                if (flag == 1) Console.WriteLine("YES");
            }
        }
    }
}


