using static System.Net.WebRequestMethods;

Console.WriteLine("Gib eine Zahl ein:");
int zahl = Convert.ToInt32(Console.ReadLine());
bool istPrim = true;

if (zahl <= 1)
{
    istPrim = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(zahl); i++)          // Optimierung: Nur bis zur Quadratwurzel der Zahl prüfen
    {                                                   //  Warum bis zur Quadratwurzel? Wenn eine Zahl zahl einen Teiler
                                                        //  größer als ihre Quadratwurzel hätte, müsste der andere Teiler
                                                        //  kleiner als die Quadratwurzel sein.Deshalb reicht es,
                                                        //  nur bis zur Quadratwurzel zu prüfen – das spart Rechenzeit.
        if (zahl % i == 0)
        {
            istPrim = false;
            break;
        }
    }
}

if (istPrim)
    Console.WriteLine(zahl + " ist eine Primzahl.");
else
    Console.WriteLine(zahl + " ist keine Primzahl.");