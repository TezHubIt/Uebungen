int eingabe;
int min = 1;
int max = 100;
Random rnd = new Random();
int n = rnd.Next(min, max + 1);
int versuche = 0;
int maxVersuche = 10; // Maximale Anzahl an Versuchen

do
{
    Console.Write("Gebe dein Zahl zwischen {0} und {1} ein,\ndu kannst es noch {2} mal probieren: ", min, max, maxVersuche - versuche);           // Zahl erraten und Versuch Counter wird Hochgezählt
    eingabe = Convert.ToInt32(Console.ReadLine());
    versuche++;

    if (eingabe == n && versuche <= maxVersuche)
    {
        Console.WriteLine();
        Console.WriteLine("RICHTIG! Die Zahl war " + n);
        Console.WriteLine("Du hast {0} Versuche gebraucht!", versuche);
    }
    else if (eingabe > n && versuche < maxVersuche)
    {
        Console.WriteLine("Die Zahl ist kleiner als " + eingabe);
    }
    else if (eingabe < n && versuche < maxVersuche)
    {
        Console.WriteLine("Die Zahl ist größer als " + eingabe);
    }
    else
    {
        Console.WriteLine("Du hast die maximale Anzahl an Versuchen erreicht! Die Zahl war " + n);
        break;
    }
    Console.WriteLine();
}
while (eingabe != n);