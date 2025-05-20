string passwort = "1234";

Console.Write("Bitte Passwort eingeben: ");
string eingabe = Console.ReadLine();

if (eingabe == passwort)
{
    Console.WriteLine("Passwort korrekt!");
}
else
{
    Console.WriteLine("Passwort falsch!");
}