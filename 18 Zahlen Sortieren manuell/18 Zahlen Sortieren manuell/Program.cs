Console.WriteLine("Zahlen sortieren, gebe 3 Zahlen ein");
int zahl1 = Convert.ToInt32(Console.ReadLine());
int zahl2 = Convert.ToInt32(Console.ReadLine());
int zahl3 = Convert.ToInt32(Console.ReadLine());

int low, mid, high;

if (zahl1 < zahl2 && zahl1 < zahl3)
{
    low = zahl1;
    if (zahl2 < zahl3)
    {
        mid = zahl2;
        high = zahl3;
    }
    else
    {
        mid = zahl3;
        high = zahl2;
    }
}
else if (zahl2 < zahl1 && zahl2 < zahl3)
{
    low = zahl2;
    if (zahl1 < zahl3)
    {
        mid = zahl1;
        high = zahl3;
    }
    else
    {
        mid = zahl3;
        high = zahl1;
    }
}
else
{
    low = zahl3;
    if (zahl1 < zahl2)
    {
        mid = zahl1;
        high = zahl2;
    }
    else
    {
        mid = zahl2;
        high = zahl1;
    }
}

Console.WriteLine($"Die Zahlen in aufsteigender Reihenfolge: {low}, {mid}, {high}");