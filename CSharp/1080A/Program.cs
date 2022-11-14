namespace Petya_and_Origami;
class Program
{
    //https://codeforces.com/problemset/problem/1080/A
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');
        int firstInput = Convert.ToInt32(split[0]);
        int secondInput = Convert.ToInt32(split[1]);
        int redSheets = 2 * firstInput;
        int greenSheets = 5 * firstInput;
        int blueSheets = 8 * firstInput;
        int answer = 0;

        answer += redSheets / secondInput;
        redSheets %= secondInput;
        if (redSheets != 0) 
        { 
            answer += 1; 
        }
        answer += greenSheets / secondInput;
        greenSheets %= secondInput;
        if (greenSheets != 0)
        { 
            answer += 1; 
        }
        answer += blueSheets / secondInput;
        blueSheets %= secondInput;
        if (blueSheets != 0)
        { 
            answer += 1; 
        }
        Console.WriteLine(answer);
        Console.ReadLine();
    }
}


