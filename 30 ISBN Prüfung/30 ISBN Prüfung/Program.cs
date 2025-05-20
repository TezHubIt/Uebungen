class ISBNPruefung
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie eine ISBN-Nummer ein:");
        string isbn = Console.ReadLine();
        if (IsValidISBN(isbn))
        {
            Console.WriteLine("Die ISBN-Nummer ist gültig.");
        }
        else
        {
            Console.WriteLine("Die ISBN-Nummer ist ungültig.");
        }
    }

    static bool IsValidISBN(string isbn)
    {
        // Remove any hyphens or spaces
        isbn = isbn.Replace("-", "").Replace(" ", "");
        // Check if the length is 10 or 13
        if (isbn.Length != 10 && isbn.Length != 13)
        {
            return false;
        }
        // Validate ISBN-10
        if (isbn.Length == 10)
        {
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsDigit(isbn[i]))
                {
                    return false;
                }
                sum += (isbn[i] - '0') * (i + 1);
            }
            char checkDigit = isbn[9];
            if (checkDigit == 'X')
            {
                sum += 10 * 10;
            }
            else if (char.IsDigit(checkDigit))
            {
                sum += (checkDigit - '0') * 10;
            }
            else
            {
                return false;
            }
            return sum % 11 == 0;
        }
        // Validate ISBN-13
        int[] weights = { 1, 3 };
        int total = 0;
        for (int i = 0; i < isbn.Length; i++)
        {
            if (!char.IsDigit(isbn[i]))
            {
                return false;
            }
            total += (isbn[i] - '0') * weights[i % 2];
        }
        return total % 10 == 0;
    }
}