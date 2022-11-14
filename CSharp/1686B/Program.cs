namespace CD_1686B;
class Program
{
    //https://codeforces.com/problemset/problem/1686/B
    public static void Main(string[] args)
    {
        uint totalCase = Convert.ToUInt32(Console.ReadLine());

        for (uint i = 0; i < totalCase; i++)
        {
            uint n = Convert.ToUInt32(Console.ReadLine());
            var v = Console.ReadLine().Split(' ');

            uint[] numarrays = new uint[n];
            for (int j = 0; j < n; j++)
            {
                numarrays[j] = Convert.ToUInt32(v[j]);
            }

            uint counter = 0;
            for (uint j = 1; j < n; j++)
            {
                if (numarrays[j - 1] > numarrays[j])
                {
                    counter++;
                    j++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}


