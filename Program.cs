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
            Utilizator jucator = null;

            while (!autentificat)
            {
                autentificat = Logare(out esteAdmin, out jucator);
            }

            //Console.WriteLine($"Autentificare reusita! Bine ai venit, {(esteAdmin ? "Administrator" : "Utilizator")}.");

            while (jucator.Balanta > 0)
            {
                Roteste(jucator);
            }
        }

        static public bool Logare(out bool esteAdmin, out Utilizator jucator)
        {
            Console.Write("Introdu numele: ");
            string nume = Console.ReadLine();

            Console.Write("Introdu parola: ");
            string parola = Console.ReadLine();

            bool succes = Autentificare.Login(nume, parola, out esteAdmin, out int balanta);

            if (succes)
            {
                jucator = new Utilizator(nume, parola, esteAdmin, balanta);
            }
            else
            {
                jucator = null;
            }
            return succes;
        }

        static public void Roteste(Utilizator jucator)
        {
            Console.WriteLine($"Balanta actuală: {jucator.Balanta} credite");

            if (jucator.Balanta <= 0)
            {
                Console.WriteLine("Nu ai suficiente credite pentru a juca!");
                return;
                
            }

            Console.WriteLine("Introdu miza (1, 2, 3, 5, 10, 20):");
            int miza = int.Parse(Console.ReadLine());

            if (miza > jucator.Balanta)
            {
                Console.WriteLine("Nu ai suficiente credite pentru această miză!");
                return;
            }


            try
            {
                jucator.Balanta -= miza;
                Pacanea.SeteazaMiza(miza);
                Item[] rezultate = Pacanea.Rotire();

                Console.WriteLine($"Rezultatele rotirii: {rezultate[0].Simbol} {rezultate[1].Simbol} {rezultate[2].Simbol}");

                int castig = Pacanea.VerificaCastig(rezultate, miza);
                jucator.Balanta += castig;

                Autentificare.SalveazaBalanta(jucator.Nume, jucator.Balanta);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare: {ex.Message}");
            }
        }




    }
}
