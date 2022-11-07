using System;
using System.Linq;

namespace CD_1712A
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = t; i > 0; i--)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
                int[] b = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
                int ans = 0;
                Array.ForEach(b, i => { if (i <= a[1] && Array.IndexOf(b, i) >= a[1]) ans++; });
                Console.WriteLine(ans);
            }
        }
    }
}
