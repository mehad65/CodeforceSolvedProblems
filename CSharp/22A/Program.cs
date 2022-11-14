namespace CD_22A;

class Program
{
    //https://codeforces.com/problemset/problem/22/A
    public static void Main(string[] args)
    {
        var input = int.Parse(Console.ReadLine());
        var a = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToList();

        var numList = new List<int>();

        for (int i = 0; i < input; i++)
        {
            if (!numList.Contains(a[i]))
            {
                numList.Add(a[i]);
            }
        }
        numList.Sort();
        if (numList.Count <= 1)
            Console.WriteLine("NO");
        else
            Console.WriteLine(numList[1]);
    }
}