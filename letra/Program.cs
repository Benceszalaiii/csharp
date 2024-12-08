using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cigany_sharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] inp = new int[] { 3, 1, 1, 2, 1, 5, 5, 4, 4, 4, 1, 2, 3, 6, 4, 6, 1, 4 };
            int mostani = 0;
            int letrakSzama = 0;
            Console.WriteLine("2. Feladat");
            foreach (int i in inp) {
                mostani += i;
                if (mostani % 10 == 0)
                {
                    letrakSzama++;
                    mostani -= 3;
                }
                Console.Write($"{mostani} ");
            }
            Console.WriteLine();
            Console.WriteLine("3. Feladat");
            Console.WriteLine($"A játék során {letrakSzama} alkalommal lépett létrára.");
            Console.WriteLine("4. Feladat");
            if (mostani >= 48)
            {
                Console.WriteLine("A jatek befejezodott");
            }
            else
            {
                Console.WriteLine("A jatek nem fejezodott be.");
            }
            Console.ReadKey();
        }
    }
}
