int x, y;
Console.Write("Geben Sie eine Zahl ein: ");
x = Convert.ToInt32(Console.ReadLine());
y = (x == 0 ? 1 : x);

Console.WriteLine($"Die Zahl ist {y}.");