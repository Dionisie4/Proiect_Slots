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
            Pacanea p1 = new Pacanea();
            p1.SeteazaMiza(1);

            Autentificare autentificare = new Autentificare();
            Console.Write("Introdu numele: ");
            string nume = Console.ReadLine();

            Console.Write("Introdu parola: ");
            string parola = Console.ReadLine();

            bool esteAdmin;
            autentificare.Login(nume, parola, out esteAdmin);
        }
    }
}
