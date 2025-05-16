Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
int zahl = Convert.ToInt32(Console.ReadLine());

if (zahl % 2 == 0)
{
    Console.WriteLine("Die " + zahl + " ist gerade");
}
else
{
    Console.WriteLine("Die " + zahl + " ist ungerade");
}
