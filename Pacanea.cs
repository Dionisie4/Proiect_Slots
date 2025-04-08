using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Slots
{
    public static class Pacanea
    {
        private static int mizaCurenta;
        private static readonly List<int> MizePermise = new List<int> { 1, 2, 3, 5, 10, 20 };

        private static List<Item> iteme = new List<Item>
        {
            new Item("Cireșe", "cireasa", 2, 75),
            new Item("Clopoțel", "clopotel", 5, 50),
            new Item("Stea", "stea", 10, 20),
            new Item("Septari", "septar", 20, 10),
            new Item("Dublu Septari", "77", 100, 1)
        };

        public static void SeteazaMiza(int valoare)
        {
            if (MizePermise.Contains(valoare))
            {
                mizaCurenta = valoare;
            }
            else
            {
                throw new ArgumentException($"Valoarea mizei este incorectă. Miza trebuie să fie una dintre următoarele: {string.Join(", ", MizePermise)}");
            }
        }

        public static Item[] Rotire()
        {
            Random rnd = new Random();
            List<Item> listaPonderata = new List<Item>();

            
            foreach (var item in iteme)
            {
                for (int i = 0; i < item.Sanse; i++)
                {
                    listaPonderata.Add(item);
                }
            }

            
            Item[] rezultat = new Item[3];
            for (int i = 0; i < 3; i++)
            {
                rezultat[i] = listaPonderata[rnd.Next(listaPonderata.Count)];
            }

            return rezultat;
        }

        public static int VerificaCastig(Item[] rezultate, int miza)
        {
            if (rezultate[0] == rezultate[1] && rezultate[1] == rezultate[2])
            {
                int castig = miza * rezultate[0].Multiplicator;
                Console.WriteLine($"Ohooo, ai castigat {castig} credite!, opreste te acum cat esti pe plus (daca esti)");
                return castig;
            }
            else
            {
                Console.WriteLine($"ai pierdut {miza} credite, csf");
                return 0;
            }
        }
    }
}

