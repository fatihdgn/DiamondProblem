// See https://aka.ms/new-console-template for more information

using System.Text;

int count = 0;

do
{
    Console.Write("Please enter an odd number above two: ");
    var sCount = Console.ReadLine();
    int.TryParse(sCount, out count);
    if (count < 2 || count % 2 == 0) Console.WriteLine("What you entered is not valid. Please try again.");
} while (count < 2 || count % 2 == 0);

Console.WriteLine("Here is your diamond");
Console.Write(print(count));
Console.WriteLine();
Console.Write("Press any key to exit...");
Console.ReadKey(true);

static string print(int n)
{
    if (n <= 2) return null;
    var sb = new StringBuilder();
    var c = (int)Math.Floor((double)n / 2);
    for (int i = c; i > 0; i--)
    {
        if (sb.Length > 0) sb.Append("\n");
        printLine(i, n, sb);
    }
    sb.Append("\n");
    printLine(0, n, sb);
    for (int i = 1; i <= c; i++)
    {
        sb.Append("\n");
        printLine(i, n, sb);
    }
    return sb.ToString();
}

static void printLine(int c, int n, StringBuilder sb)
{
    var x = n - c * 2;
    for (int i = 0; i < c; i++) sb.Append(" ");
    for (int i = 0; i < x; i++) sb.Append("*");
    for (int i = 0; i < c; i++) sb.Append(" ");
}