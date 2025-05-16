Console.WriteLine("Bitte gebe eine Zahl ein: ");
int n = Convert.ToInt32(Console.ReadLine());

int summe  = 0;

for (int i = 1; i <= n; i++)
{
    summe += i;
}

Console.WriteLine("Die Summe 1 bis " + n + " ist " +  summe);



/* 

While Schleife

int summe = 0;
int i = 1;

while (i <= n)
{
    summe += i;
    i++;
}

__________________________

do-while Schleife

int summe = 0;
int i = 1;

do
{
    summe += i;
    i++;
}
while (i <= n);

 */