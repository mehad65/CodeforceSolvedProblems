//https://codeforces.com/problemset/problem/1672/A

var input = int.Parse(Console.ReadLine().Trim());
while (input-- > 0)
{
    Console.ReadLine();
    string[] line = Console.ReadLine().Trim().Split(' ');
    var a = Array.ConvertAll(line, x => int.Parse(x) - 1).Sum();
    Console.WriteLine(a % 2 == 1 ? "errorgorn" : "maomao90");
}
