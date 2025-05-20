Console.Write("Drücke eine Taste: ");

ConsoleKeyInfo taste = Console.ReadKey(true);

Console.WriteLine($"Taste: {taste.Key} ({(int)taste.Key})");

Console.WriteLine($"Zeichen: {taste.KeyChar} ({(int)taste.KeyChar})");

Console.WriteLine($"Zusatz Taste: {taste.Modifiers} ({(int)taste.Modifiers})");
