Console.WriteLine("Gib die erste Zahl ein:");
int zahl1 = int.Parse(Console.ReadLine());

Console.WriteLine("Gib die zweite Zahl ein:");
int zahl2 = int.Parse(Console.ReadLine());

int ergebnis = zahl1 + zahl2;
Console.WriteLine("Das Ergebnis ist: " + ergebnis);


Console.WriteLine("Gib die erste Zahl ein:");
string eingabe1 = Console.ReadLine();
int zahl3 = Convert.ToInt32(eingabe1);

Console.WriteLine("Gib die zweite Zahl ein:");
string eingabe2 = Console.ReadLine();
int zahl4 = Convert.ToInt32(eingabe2);

int ergebnis2 = zahl3 + zahl4;
Console.WriteLine("Das Ergebnis ist: " + ergebnis2);

