﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00___Buch
{
    internal class Person
    {
        public string Name;
        public int Age;
        public void Laufen()
        {
            Console.WriteLine($"{Name} läuft.");
        }
    }
}
