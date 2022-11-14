using System;
using System.Collections.Generic;
using System.Linq;

namespace CD_1688B
{
    //https://codeforces.com/problemset/problem/1688/B
    class Program
    {
        static void Main(string[] args)
        {
            int iterationCount = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < iterationCount; k++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var a = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToList();
                int oddCounter = 0;
                Dictionary<int, int> evenCounter = new Dictionary<int, int>();
                int key = 0;

                for (int i = 0; i < n; i++)
                {
                    if ((a[i] & 1) == 0)
                    {
                        evenCounter.Add(key++, CountZero(a[i]));
                        continue;
                    }
                    oddCounter++;
                }


                if (oddCounter > 0)
                {
                    Console.WriteLine(evenCounter.Count);
                }
                else
                {
                    if (evenCounter.Count > 0)
                    {
                        int leastTrailingZeros = evenCounter.Min(x => x.Value);
                        int noOfEvens = evenCounter.Count() - 1;
                        Console.WriteLine(leastTrailingZeros + noOfEvens);
                    }
                    else
                        Console.WriteLine(0);
                }
            }
        }

        static int CountZero(int n)
        {
            int counter = default;
            while ((n & 1) == 0)
            {
                counter++;
                n = n >> 1;
            }
            return counter;
        }
    }
}