namespace CD_1255A;

class Program
{
    //https://codeforces.com/problemset/problem/1255/A
    static void Main(string[] args)
    {
        int firstInput = Convert.ToInt32(Console.ReadLine());
        int secondInput = 0, thirdInput = 0, dif = 0;
        for (int x = 0; x < firstInput; ++x)
        {
            int answer = 0;
            string[] split = Console.ReadLine().Split(' ');
            secondInput = Convert.ToInt32(split[0]);
            thirdInput = Convert.ToInt32(split[1]);
            dif = Math.Abs(secondInput - thirdInput);
            answer = dif / 5;
            dif %= 5;
            answer += dif / 2;
            dif %= 2;
            answer += dif;
            Console.WriteLine(answer);
        }
        Console.ReadLine();
    }
}

