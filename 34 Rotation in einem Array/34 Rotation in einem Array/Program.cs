string[] buchstaben = { "A", "B", "C", "D", "E", "F", "G" };

Console.WriteLine("Vor der Rotation:");
foreach (string buchstabe in buchstaben)
{
    Console.Write(buchstabe + " ");
}

RotateRight(buchstaben);

Console.WriteLine("\nNach der Rotation:");
foreach (string buchstabe in buchstaben)
{
    Console.Write(buchstabe + " ");
}

static void RotateRight(string[] arr)
{
    string tmp = arr[arr.Length - 1]; // Letztes Element speichern
    for (int i = arr.Length - 1; i > 0; i--)
    {
        arr[i] = arr[i - 1]; // Elemente nach rechts verschieben - z.b. arr[6] wird mit arr[5] überschrieben 
    }
    arr[0] = tmp; // Erstes Element auf das letzte setzen
}