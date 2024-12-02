using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fogyokura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hetek szama=");
            int hetekSzama = Convert.ToInt32(Console.ReadLine());
            Console.Write("Elerni kivant testtomeg (kg)=");
            decimal kivantTomeg = Convert.ToDecimal(Console.ReadLine());
            decimal[] hetiSulyok = new decimal[hetekSzama];
            int elertHetIndex = -1;
            int sulyosHetekSzama = 0;
            for (int i = 0; i < hetekSzama; i++)
            {
                Console.Write($"A(z) {i + 1}. heti suly=");
                hetiSulyok[i] = Convert.ToDecimal(Console.ReadLine());
                if (hetiSulyok[i] < kivantTomeg && elertHetIndex == -1)
                {
                    elertHetIndex = i;
                }
                if (i > 0 && hetiSulyok[i] > hetiSulyok[i - 1])
                {
                    sulyosHetekSzama++;
                }
            }
            Console.WriteLine(string.Join(", ", hetiSulyok));
            if (elertHetIndex >= 0)
            {
                Console.WriteLine($"Mari neni a(z) {elertHetIndex + 1}. heten erte el celjat.");
            }
            else
            {
                Console.WriteLine("Mari neni sajnos nem erte el a celjat.");
            }

            Console.WriteLine($"A tomeg {sulyosHetekSzama} esetben nott egyik hetrol a masikra.");
            Console.ReadKey();
        }
        
    }
    
}
