using System;
using System.Collections.Generic;
using System.Linq;

namespace kitalalo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] szavak = new string[]
            {
                "fuvola", "csirke", "adatok", "asztal", "fogoly", "bicska",
                "farkas", "almafa", "babona", "gerinc", "dervis", "bagoly",
                "ecetes", "angyal", "boglya"
            };
            Random rand = new Random();
            List<char> kivalasztott = szavak[rand.Next(0, szavak.Length)].ToCharArray().ToList();
            char[] talalatok = new char[kivalasztott.Count];
            int tippelesekSzama = 0;
            for (int i = 0; i < kivalasztott.Count; i++)
            {
                talalatok[i] = '.';
            }

            while (!kivalasztott.SequenceEqual(talalatok))
            {
                Console.Write("Kérem a tippet: ");
                List<char> tipp = Console.ReadLine().ToCharArray().ToList();
                tippelesekSzama++;
                if (tipp.SequenceEqual("stop".ToCharArray())) // Ha tipp == "stop" akkor kilep a program
                {
                    System.Environment.Exit(0);
                }

                if (tipp.Count != 6) // Hat betusnek kell lennie a szonak.
                {
                    continue;
                }
                for (int i = 0; i < tipp.Count; i++) 
                {
                    if (tipp[i] == kivalasztott[i])
                    {
                        talalatok[i] = kivalasztott[i];
                    }
                }

                Console.WriteLine($"Az eredmény: {new string(talalatok)}");
                Console.WriteLine(); // Valamiert a mintan van egy ures sor...
            }

            Console.WriteLine($"{tippelesekSzama} tippeléssel sikerült kitalálni.");
            Console.ReadKey();
        }
    }
}