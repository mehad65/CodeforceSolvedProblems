namespace CD_850A;

class Program
{
    //https://codeforces.com/problemset/problem/855/A
    static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());
        string[] s = new string[input];
        for (int i = 0; i < input; i++)
        {
            s[i] = Convert.ToString(Console.ReadLine());
        }
        int count = 1;
        string answer = " ";
        Console.WriteLine("NO");
        for (int i = 1; i < input; i++)
        {
            for (int j = 0; j < count; j++)
            {
                if (s[i] == s[j])
                {
                    answer = "YES";
                    break;
                }
                else answer = "NO";
            }
            Console.WriteLine(answer);
            count++;

        }
    }
}
