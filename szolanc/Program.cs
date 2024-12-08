using System;
using System.Collections.Generic;
using System.Linq;

namespace szolanc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> szavak = new List<string>();
            bool helyes = true;
            Console.Write("1. szo: ");
            szavak = szavak.Append(Console.ReadLine()).ToList();
            int betukSzama = szavak.First().Length;
            while (helyes)
            {
                Console.Write($"{szavak.Count + 1}. szo: ");
                string inp = Console.ReadLine();

                if (betukSzama != inp.Length)
                {
                    Console.WriteLine("A karakterek száma téves!");
                    helyes = false;
                    continue;
                }

                if (szavak.Last().Last() != inp.First()) // Ha az utolso szo utolso betuje az input elso betuje
                {
                    Console.WriteLine("Nem illeszkedett!");
                    helyes = false;
                    continue;
                }
                // Csak akkor jut el ide a program ha megfelel mindennek (hiba => continue)
                szavak = szavak.Append(inp).ToList();
            }

            Console.WriteLine($"Helyes lépések száma: {szavak.Count}");
            Console.Write("Szint: ");
            // Ez lehet csunya de ez a legszebb megoldas 
            switch (szavak.Count)
            {
                case int szavakCount when (szavakCount <= 2):
                    Console.Write("kezdő");
                    break;
                case int szavakCount when (szavakCount <= 5):
                    Console.Write("közepes");
                    break;
                case int szavakCount when (szavakCount >= 6):
                    Console.Write("haladó");
                    break;
            }

            Console.ReadKey();
        }
    }
}