using System;
using System.Collections.Generic;
using System.Linq;

namespace robot
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Kerem a robot parancsait: ");
            string parancsok = Console.ReadLine();
            Dictionary<char, int> parancsokDict = new Dictionary<char, int>()
                { { 'E', 0 }, { 'K', 0 }, { 'D', 0 }, { 'N', 0 } };
            foreach (char c in parancsok)
            {
                switch (c)
                {
                    case 'E':
                        parancsokDict['E']++;
                        break;
                    case 'K':
                        parancsokDict['K']++;
                        break;
                    case 'D':
                        parancsokDict['D']++;
                        break;
                    case 'N':
                        parancsokDict['N']++;
                        break;
                }
            }

            foreach (KeyValuePair<char,int> keyValuePair in parancsokDict)
            {
                Console.WriteLine($"{keyValuePair.Key} betuk szama: {keyValuePair.Value}");
            }
            // Elmozdulas Nyugat iranyba, ha negative => Keletre mozog
            int deltaX = parancsokDict['N'] - parancsokDict['K'];
            // Elmozdulas Eszak iranyba, ha negative => Eszakra mozog
            int deltaY = parancsokDict['D'] - parancsokDict['E'];
            string legrovidebb = String.Empty;
            if (deltaX < 0)
            {
                legrovidebb = new string(Enumerable.Repeat('K', deltaX * -1).ToArray());
            }
            else
            {
                legrovidebb = new string(Enumerable.Repeat('N', deltaX).ToArray());
            }
            if (deltaY < 0)
            {
                legrovidebb += new string(Enumerable.Repeat('E', deltaY * -1).ToArray());
            }
            else
            {
                legrovidebb += new string(Enumerable.Repeat('D', deltaY).ToArray());
            }

            Console.WriteLine($"Egy legrövidebb út parancsszava: {legrovidebb}");
            Console.ReadKey();
        }
    }
}