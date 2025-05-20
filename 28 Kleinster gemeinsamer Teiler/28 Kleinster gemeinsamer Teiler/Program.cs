int a, b;

Console.Write("Geben Sie die erste Zahl ein: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Geben Sie die zweite Zahl ein: ");
b = Convert.ToInt32(Console.ReadLine());

int ggt = GGT(a, b);
int kgv = KGV(a, b, ggt);

Console.WriteLine($"Der größte gemeinsame Teiler von {a} und {b} ist: {ggt}");
Console.WriteLine($"Der kleinste gemeinsame Vielfache von {a} und {b} ist: {kgv}");


static int GGT(int x, int y)
{
    while (y != 0)
    {
        int temp = y;
        y = x % y;
        x = temp;
    }
    return x;
}

static int KGV(int x, int y, int ggt)
{
    return (x * y) / ggt;
}

