Console.Write("Welche Zeichen sollen auf Palindrom überprüft werden?: ");
string input = Console.ReadLine() ?? string.Empty;


if (PalindromCheck(input))
{
    Console.WriteLine("Das ist ein Palindrom.");
}
else
{
    Console.WriteLine("Das ist kein Palindrom.");
}
{
    
}


static bool PalindromCheck(string input)
{
    // Alle nicht alphanumerischen Zeichen entfernen und in Kleinbuchstaben umwandeln
    string cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    // Prüfen, ob der bereinigte String gleich seinem umgekehrten Pendant ist
    return cleanedInput.SequenceEqual(cleanedInput.Reverse());
}
