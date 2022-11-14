namespace CD_1561A;

class Program
{
   //https://codeforces.com/problemset/problem/1561/A
    static bool isSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- != 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputNumbers = Console.ReadLine().Split().Select(m => int.Parse(m)).ToArray();
            int count = 0;
            while (!isSorted(inputNumbers))
            {
                count++;
                for (int i = 1 - count & 1; i < n - 1; i += 2)
                {
                    if (inputNumbers[i] > inputNumbers[i + 1])
                    {
                        inputNumbers[i] = inputNumbers[i + 1] ^ inputNumbers[i];
                        inputNumbers[i + 1] = inputNumbers[i + 1] ^ inputNumbers[i];
                        inputNumbers[i] = inputNumbers[i + 1] ^ inputNumbers[i];
                    }
                }

            }
            Console.WriteLine(count);
        }
    }
}
