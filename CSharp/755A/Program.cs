namespace CD_755A;

class Program
{
    //https://codeforces.com/problemset/problem/755/A
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
            Console.WriteLine(3);
        else if (n % 2 != 0)
            Console.WriteLine(1);
        else
        {
            int i = 1;
            while (true)
            {
                if (isPrime(n * i + 1))
                    i++;
                else
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
    public static bool isPrime(int number)
    {
        for (int i = 3; i <= number / 2; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
