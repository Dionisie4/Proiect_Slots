using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Slots
{
    class Autentificare
    {
        private static string cale = "Utilizatori.txt";

        public static bool Login (string nume, string parola, out bool esteAdmin, out int balanta)
        {
            esteAdmin = false;
            balanta = 0;

            if (!File.Exists(cale))
            {
                Console.WriteLine("Fisierul cu utilizatori nu exista!");
            }

            foreach(var linie in File.ReadLines(cale))
            {
                string[] parti = linie.Split('.');
                if (parti.Length == 4)
                {
                    string numeDinFisier = parti[0];
                    string parolaDinFisier = parti[1];
                    bool statusAdmin = parti[2].Trim().ToLower() == "true";
                    int balantaDinFisier = int.Parse(parti[3]);

                    if (numeDinFisier == nume && parolaDinFisier == parola)
                    {
                        esteAdmin = statusAdmin;
                        balanta = balantaDinFisier;
                        Console.WriteLine($"Autentificare reusita!{(esteAdmin ? "Administrator" : "Utilizator Obisnuit")}");
                        return true;
                    }
                }
            }
            Console.WriteLine("Nume sau Parola gresite!");
            return false;

        }

        public static void SalveazaBalanta(string nume, int balanta)
        {
            if (!File.Exists(cale))
            {
                Console.WriteLine("Fișierul cu utilizatori nu există!");
                return;
            }
            var linii = File.ReadAllLines(cale);
            for (int i = 0; i < linii.Length; i++)
            {
                string[] parti = linii[i].Split('.');
                if (parti.Length == 4 && parti[0] == nume)
                {
                    parti[3] = balanta.ToString();
                    linii[i] = string.Join(".", parti);
                    break;
                }
            }
            File.WriteAllLines(cale, linii);
        }
    }
}
