using System;

class Program
{
    static void Main()
    {
        int flags = 0b_0000_0101; // 5 in Dezimal, Bits 0 und 2 gesetzt
        Console.WriteLine("Start:       " + Convert.ToString(flags, 2).PadLeft(8, '0'));

        // Bit 1 setzen
        flags |= (1 << 6);
        Console.WriteLine("Bit 1 setzen:" + Convert.ToString(flags, 2).PadLeft(8, '0'));

        // Bit 2 löschen
        flags &= ~(1 << 6);
        Console.WriteLine("Bit 2 löschen:" + Convert.ToString(flags, 2).PadLeft(8, '0'));

        // Bit 0 umkehren (toggle)
        flags ^= (1 << 6);
        Console.WriteLine("Bit 0 toggle:" + Convert.ToString(flags, 2).PadLeft(8, '0'));

        // Endwert auch dezimal anzeigen
        Console.WriteLine("Ergebnis (dezimal): " + flags);
    }
}
