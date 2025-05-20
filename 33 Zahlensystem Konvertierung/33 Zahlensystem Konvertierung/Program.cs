
string input;

Console.WriteLine("Dezimalzahl wird in Binär und Hexadezimal umgewandelt");

do
{
    Console.Write("Geben Sie eine Dezimalzahl ein (Enter zum Beenden): ");
    input = Console.ReadLine();

    if (!string.IsNullOrEmpty(input))
    {
        if (int.TryParse(input, out int zahl))
        {
            string binaer = Convert.ToString(zahl, 2);

            // Mit führenden Nullen auf ein Vielfaches von 4 auffüllen
            int padding = 4 - (binaer.Length % 4);
            if (padding != 4)
            {
                binaer = binaer.PadLeft(binaer.Length + padding, '0');
            }

            // Von rechts nach links in 4er-Gruppen aufteilen
            string gruppiert = "";
            for (int i = 0; i < binaer.Length; i += 4)
            {
                if (i > 0) gruppiert += " ";
                gruppiert += binaer.Substring(i, 4);
            }

            Console.WriteLine($"\nDie Binärdarstellung von {zahl} ist: {gruppiert}");
            Console.WriteLine($"Die Hexadezimaldarstellung von {zahl} ist: {Convert.ToString(zahl, 16).ToUpper()}\n");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte eine ganze Zahl eingeben.\n");
        }
    }

} while (!string.IsNullOrEmpty(input));

