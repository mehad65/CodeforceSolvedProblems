namespace CD_38A;
class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[n - 1];
        for (int i = 0; i < n - 1; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        string[] input2 = Console.ReadLine().Split(' ');
        int a = int.Parse(input2[0]);
        int b = int.Parse(input2[1]);

        int total = 0;

        for (int i = a + 1; i <= b; i++)
        {
            total += numbers[i - 2];
        }
        Console.WriteLine(total);
    }
}

