Console.WriteLine("Texteingabe: ");
string text = Console.ReadLine();

char[] textArray = text.ToCharArray();                          // Text wird in ein char-Array umgewandelt
Array.Reverse(textArray);                                       // Array wird umgekehrt
string reversedText = new string(textArray);                    // neues String-Objekt wird erstellt aus dem Array

Console.WriteLine("Umgekehrter Text: " + reversedText);