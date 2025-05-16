for (int i = 1; i <= 10; i++)               // i ist der erste Multiplikator der Tabelle, wiederholung bis 10 erreicht ist
{
    for (int n = 1; n <= 10; n++)          // i wird mit n solange Multipliziert bis n = 10 
    {
        int ergebnis = i * n;
        Console.WriteLine(i + " X " + n + " = " + ergebnis);
    }
    Console.WriteLine();
}