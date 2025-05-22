int flags = 0b_0000_0101; // Bits 0 und 2 gesetzt

// Bit 1 setzen
flags |= (1 << 1); // Ergebnis: 0b_0000_0111

// Bit 2 löschen
flags &= ~(1 << 2); // Ergebnis: 0b_0000_0011

// Bit 0 umkehren (toggle)
flags ^= (1 << 0); // Ergebnis: 0b_0000_0010
