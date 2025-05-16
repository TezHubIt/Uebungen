Console.WriteLine("Gebe eine Zahl ein: ");
int n = Convert.ToInt32(Console.ReadLine());        

for (int i = 1; i <=n; i++)
{
    int ergebnis = i * i;
    Console.WriteLine(i + "² = " + ergebnis);
}