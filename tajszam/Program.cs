using System;
using System.Linq;

namespace taj
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Kérem a TAJ-számot:");
            
            int[] tajszam = Console.ReadLine()              // Beolvasunk, stringet kapunk
                .ToCharArray()                              // char[]-t csinalunk belole, ugyanaz mint a split()
                .Select(c => int.Parse(c.ToString()))  // Select => atalakitjuk az osszes karaktert szamma (kell a c.ToString() mert az ASCII kodot kapnank vissza)
                                                            // Select ugyanaz mint egy foreach, csak egy sorban
                .ToArray();                                 // Majd osszegyujtjuk ezeket egy Array-be
            int ellenorzoSzam = tajszam.Last();
            tajszam[tajszam.Length - 1] = 0; // Ne szamitson bele az osszegzesbe
            Console.WriteLine($"Az ellenőrzőszámjegy: {ellenorzoSzam}");
            for (int i = 0; i < 8; i++)
            {
                // Amiert a szorzat utan nem erunk a tajszamhoz, alakitsuk at ugyanazt a listat
                if (i % 2 == 0) // Keep in mind: 0. index 
                {
                    tajszam[i] *= 3;
                }
                else
                {
                    tajszam[i] *= 7;
                }

            }

            Console.WriteLine($"A szorzatok összege: {tajszam.Sum()}");
            if (tajszam.Sum() % 10 == ellenorzoSzam)
            {
                Console.WriteLine("Helyes a szám!");
            }
            else
            {
                Console.WriteLine("Hibás a szám!");
            }

            Console.ReadKey();
        }
        }
        
}