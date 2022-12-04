using static System.Console;
using static System.Convert;

int T = ToInt32(ReadLine());
for (int t = 0; t < T; t++)
{
    _ = ReadLine();
    int[] nums = ReadLine().Split().Select(x => ToInt32(x)).ToArray();

    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] -= i;
    }

    int min = nums.Min();
    int max = nums.Max();

    if (max - min <= 2)
    {
        WriteLine("Yes");
    }

    else
    {
        WriteLine("NO");
    }
}