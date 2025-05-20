Console.Write("Vollständiger Name: ");
string name = Console.ReadLine();

// Vollsätndigen Namen in Vor- und Nachnamen aufteilen
string[] namenTeile = name.Split(' ');  // Am Leerzeichen aufteilen

if (namenTeile.Length == 2)
{
    string vorname = namenTeile[0];
    string nachname = namenTeile[1];
  
    Console.WriteLine($"Vorname: {vorname}");
    Console.WriteLine($"Nachname: {nachname}");
}
else
{
    Console.WriteLine("Bitte geben Sie Ihren vollständigen Namen an (Vorname Nachname).");
}
