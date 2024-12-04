using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace szallitas
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            List<int> targyak = new List<int>(){16, 8, 9, 4, 3, 2, 4, 7, 7, 12, 3, 5, 4, 3, 2};
            List<int> dobozok = new List<int>() { 0 };
            Console.WriteLine("2. Feladat");
            Console.WriteLine($"A tárgyak tömegének összege: {targyak.Sum()} kg");
            foreach (int targy in targyak)
            {
                if (dobozok.Last() + targy > 20)
                {
                    dobozok = dobozok.Append(targy).ToList();
                }
                else
                {
                    dobozok[dobozok.Count - 1] += targy;
                }
            }

            Console.WriteLine("3. Feladat");
            Console.WriteLine($"A dobozok tartalmának tömege (kg): {string.Join(" ", dobozok)}");
            Console.WriteLine($"A szükséges dobozok száma: {dobozok.Count}");
            Console.ReadKey();
        }
    }
}