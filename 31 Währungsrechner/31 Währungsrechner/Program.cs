double dollar = 1.13;

Console.Write("Geben Sie den Betrag in Euro ein: ");
double input = Convert.ToDouble(Console.ReadLine());

// wichtig double zu formatieren 0.00
Console.WriteLine($"Der Betrag in Dollar beträgt: ${(input * dollar):0.00}");



