List<double> notenListe = new List<double>();

Console.WriteLine("Geben Sie die Note ein (z.B. 2,5 oder 3) oder drücken Sie Enter zum beenden");

while (true)
{
    Console.Write("Note: ");
    string note = Console.ReadLine();
    if (string.IsNullOrEmpty(note))
    {
        break;
    }
    if (double.TryParse(note, out double notenWert))
    {
        if (notenWert < 1.0 || notenWert > 6.0)
        {
            Console.WriteLine("Bitte geben Sie eine gültige Note zwischen 1,0 und 6,0 ein.");
            continue;
        }
        notenListe.Add(notenWert);

    }
    else
    {
        Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
    }
}

double durchschnitt = notenListe.Average();
Console.WriteLine($"\nNotendurchschnitt: {durchschnitt:0.00}");