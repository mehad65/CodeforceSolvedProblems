namespace Codeforces
{
    //https://codeforces.com/problemset/problem/1612/A
    class CD_1612A
    {
        static void Main(string[] args)
        {
            long n = Int64.Parse(Console.ReadLine());
            string[] inputlist = new string[n];
            for (int i = 0; i < n; i++)
            {
                inputlist[i] = Console.ReadLine();
            }

            for (int k = 0; k < n; k++)
            {
                int x_b = int.Parse(inputlist[k].Split(' ')[0]);
                int y_b = int.Parse(inputlist[k].Split(' ')[1]);

                if ((x_b + y_b) % 2 != 0)
                {
                    Console.WriteLine("-1 -1");
                }
                else
                {
                    int x_c = (int)Math.Ceiling((decimal)x_b / 2);
                    int y_c = (int)Math.Floor((decimal)y_b / 2);
                    Console.WriteLine(string.Format("{0} {1}", x_c, y_c));
                }
            }
            Console.ReadLine();
        }

    }
}
