Console.WriteLine("Zeitumrechnung in Sekunden");


Console.WriteLine("Gebe die Stunden an: ");
int stunden = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Gebe die Minuten an: ");
int minuten = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Gebe die Sekunden an: ");
int sekunden = Convert.ToInt32(Console.ReadLine());


int gesamtSekunden = (stunden * 3600) + (minuten * 60) + sekunden;
Console.WriteLine($"Die Zeit in Sekunden beträgt: {gesamtSekunden} Sekunden");
