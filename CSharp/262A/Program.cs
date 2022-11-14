namespace CD_262A;

public class Program
{
    //https://codeforces.com/problemset/problem/262/A
    static void Main(string[] args)
    {
        int[] numberArray = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int n = numberArray[0];
        int k = numberArray[1];
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int count = 0;

        foreach (var num in a)
        {
            int totalCount = num.ToString().Count(x => x == '4' || x == '7');
            if (totalCount <= k)
                count++;
        }
        Console.WriteLine(count);
    }
}
