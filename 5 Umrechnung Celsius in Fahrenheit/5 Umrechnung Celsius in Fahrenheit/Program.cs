int Celsius;
double Fahrenheit;

Console.WriteLine("Geben Sie die Temperatur in Celsius ein:");
Celsius = Convert.ToInt32(Console.ReadLine());
Fahrenheit = Celsius * 1.8 + 32;
Console.WriteLine("Die Temperatur in Fahrenheit ist: " + Fahrenheit);


