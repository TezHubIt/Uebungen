int versuch;
int min = 1;
int max = 100;
Random rnd = new Random();
int n = rnd.Next(min, max + 1);
int versuche = 0;

do
{
    Console.Write("Gebe dein Zahl zwischen {0} und {1} ein: ", min, max);           // Zahl erraten und Versuch Counter wird Hochgezählt
    versuch = Convert.ToInt32(Console.ReadLine());
    versuche++;

    if (versuch == n)
    {
        Console.WriteLine();
        Console.WriteLine("RICHTIG! Die Zahl war " + n);
        Console.WriteLine("Du hast {0} Versuche gebraucht!", versuche);
    }
    else if (versuch > n)
    {
        Console.WriteLine("Die Zahl ist kleiner als " + versuch);
    }
    else if (versuch < n)
    {
        Console.WriteLine("Die Zahl ist größer als " + versuch);
    }

    Console.WriteLine();
}
while (versuch != n);


