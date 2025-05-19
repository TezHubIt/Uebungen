using System.Linq;                                                  // Für die Verwendung von Min, Max und Average

Console.WriteLine("Wieviele Zahlen willst du eingeben: ");
int anzahl = Convert.ToInt32(Console.ReadLine());                   // Anzahl der Zahlen festlegen
int[] zahlen = new int[anzahl];                                     //  es wird ein Array erstellt mit "Anzahl" an Speicherplätzen


Console.WriteLine($"Gebe {anzahl} Zahlen ein: ");


for (int i = 0; i < anzahl; i++)
{
    Console.WriteLine($"Zahl {i + 1}: ");
    zahlen[i] = Convert.ToInt32(Console.ReadLine());
}


int min = zahlen.Min();                                                                                                               
int max = zahlen.Max();
double durchschnitt = zahlen.Average();                                                   

Console.WriteLine($"Die kleinste Zahl ist: {min}");
Console.WriteLine($"Die größte Zahl ist: {max}");
Console.WriteLine($"Der Durchschnitt ist: {durchschnitt}");

