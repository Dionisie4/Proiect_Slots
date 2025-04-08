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
            while (true)
            {
                Roteste();
            }
        }
        static public void Roteste()
        {

        Console.WriteLine("Introdu miza (1, 2, 3, 5, 10, 20):");
        int miza = int.Parse(Console.ReadLine());

        try
        {
            Pacanea.SeteazaMiza(miza);  // Setează miza
            Item[] rezultate = Pacanea.Rotire();  // Rotire slot

            Console.WriteLine($"Rezultatele rotirii: {rezultate[0].Simbol} {rezultate[1].Simbol} {rezultate[2].Simbol}");

            int castig = Pacanea.VerificaCastig(rezultate, miza);
            Console.WriteLine($"Balanța după rotire: {castig} monede");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
        }

        public static void Logare()
        {
            Console.Write("Introdu numele: ");
            string nume = Console.ReadLine();

            Console.Write("Introdu parola: ");
            string parola = Console.ReadLine();

            bool esteAdmin;
            Autentificare.Login(nume, parola, out esteAdmin);
        }
    }
}
