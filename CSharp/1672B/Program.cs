//https://codeforces.com/problemset/problem/1672/B

int input = Convert.ToInt32(Console.ReadLine());
while (input-- != 0)
{
    string innerInput = Console.ReadLine();
    int count = 0;
    bool flag = true;
    for (int i = 0; i < innerInput.Length; i++)
    {
        if (innerInput[i] == 'A')
        {
            count++;
        }
        else
        {
            count--;
            if (count < 0)
            {
                flag = false;
                break;
            }
        }
    }
    if (innerInput[innerInput.Length - 1] == 'A')
    {
        flag = false;
    }
    if (flag)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}