Console.WriteLine("Gib Zahl 1 ein: ");
int zahl1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gibe Rechenzeichen ein (+, -, * oder / ): ");
string rz = Console.ReadLine(); 

Console.WriteLine("Gib Zahl 2 ein: ");
int zahl2 = Convert.ToInt32(Console.ReadLine());


double ergebnis = 0;


if (rz == "+")
{
    ergebnis = zahl1 + zahl2;
}
else if (rz == "-")
{
    ergebnis = zahl1 - zahl2;
}
else if (rz == "*")
{
    ergebnis= zahl1 * zahl2;
}
else if (rz == "/")
{
    ergebnis = zahl1 / zahl2;
}

Console.WriteLine("Ergebnis: " + ergebnis);

