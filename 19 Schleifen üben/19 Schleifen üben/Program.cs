Console.WriteLine("Wie viele Zeilen?");
int zeilen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();

for (int i = 1; i <= zeilen; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();


for (int i = 1; i <= zeilen; i++)
{
    for (int j = 1; j <= zeilen; j++)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}