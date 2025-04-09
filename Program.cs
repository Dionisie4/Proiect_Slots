using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Slots
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool autentificat = false;
            bool esteAdmin = false;

            while (!autentificat)
            {
                autentificat = Logare(out esteAdmin);
            }

            Console.WriteLine($"Autentificare reușită! Bine ai venit, {(esteAdmin ? "Administrator" : "Utilizator")}.");

            while (true)
            {
                Roteste();
            }
        }

        static public bool Logare(out bool esteAdmin)
        {
            Console.Write("Introdu numele: ");
            string nume = Console.ReadLine();

            Console.Write("Introdu parola: ");
            string parola = Console.ReadLine();

            // Corectăm apelul metodei Login, acum returnează valoarea
            return Autentificare.Login(nume, parola, out esteAdmin);
        }

        static public void Roteste()
        {
            Console.WriteLine("Introdu miza (1, 2, 3, 5, 10, 20):");
            int miza = int.Parse(Console.ReadLine());

            try
            {
                Pacanea.SeteazaMiza(miza);
                Item[] rezultate = Pacanea.Rotire();

                Console.WriteLine($"Rezultatele rotirii: {rezultate[0].Simbol} {rezultate[1].Simbol} {rezultate[2].Simbol}");

                int castig = Pacanea.VerificaCastig(rezultate, miza);
                Console.WriteLine($"Balanta după rotire: {castig} credite");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare: {ex.Message}");
            }
        }




    }
}
