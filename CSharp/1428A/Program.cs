namespace CD_1428A;

class Program
{
    //https://codeforces.com/problemset/problem/1428/A
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        string result = "";
        for (int i = 0; i < t; i++)
        {
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            result += ((inputArray[2] - inputArray[0] >= 0 ? inputArray[2] - inputArray[0] : ((inputArray[2] - inputArray[0]) * (-1))) + (inputArray[3] - inputArray[1] >= 0 ? inputArray[3] - inputArray[1] : ((inputArray[3] - inputArray[1]) * (-1))) + ((inputArray[2] != inputArray[0] && inputArray[3] != inputArray[1]) ? 2 : 0)) + (i != t - 1 ? "\n" : "");
        }
        Console.WriteLine(result);
    }
}