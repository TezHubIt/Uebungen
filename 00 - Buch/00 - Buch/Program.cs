// Beispiel: ..\Kapitel 2\LogischeOperatoren
class Program
{
    static void Main(string[] args)
    {
        int x = 8;
        int y = 8;
        // wenn die Bedingung wahr ist, dann dies durch eine
        // Ausgabe an der Konsole bestätigen
        if ((x != y) || DoSomething())
            Console.WriteLine("Bedingung ist erfüllt");
        Console.ReadLine();
    }
    // benutzerdefinierte Methode
    static bool DoSomething()
    {
        Console.WriteLine("in DoSomething");
        return true;
    }
}