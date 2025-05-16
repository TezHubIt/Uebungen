using System.Numerics;

Console.WriteLine("Gebe die Zahl ein: ");
int n = Convert.ToInt32(Console.ReadLine());

BigInteger fakultät = 1;
for (int i = 1; i <= n; i++)
{
    fakultät *= i;
}
Console.WriteLine($"Die Fakultät von {n} ist {fakultät}.");

