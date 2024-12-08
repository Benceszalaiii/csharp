using System;
using System.Linq;

namespace kockak
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Hány alkalommal legyen feldobás?");
            int hanyszor = Convert.ToInt32(Console.ReadLine());
            int Anni = 0;
            int Panni = 0;
            Random rand = new Random();
            for (int i = 0; i < hanyszor; i++)
            {
                string nyertes = "";
                int[] dobasok = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    dobasok[j] = rand.Next(1, 7); // Also inclusive, Felso exclusive (1 benne van, 7 nincs)
                }
                if (dobasok.Sum() >= 10)
                {
                    Panni++;
                    nyertes = "Panni";
                }
                else
                {
                    Anni++;
                    nyertes = "Anni";
                }

                Console.WriteLine($"Dobás: {dobasok[0]} + {dobasok[1]} + {dobasok[2]} = {dobasok.Sum()} Nyert: {nyertes}");
            }

            Console.WriteLine($"A játék során {Anni} alkalommal Anni, 3 alkalommal {Panni} nyert.");
            Console.ReadKey();
        }
    }
}