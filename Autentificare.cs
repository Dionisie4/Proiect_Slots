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
        private string cale = "Utilizatori.txt";

        public bool Login (string nume, string parola, out bool esteAdmin)
        {
            esteAdmin = false;

            if (!File.Exists(cale))
            {
                Console.WriteLine("Fisierul cu utilizatori nu exista!");
            }

            foreach(var linie in File.ReadLines(cale))
            {
                string[] parti = linie.Split('.');
                if (parti.Length == 3 )
                {
                    string numeDinFisier = parti[0];
                    string parolaDinFisier = parti[1];
                    bool statusAdmin = parti[2].Trim().ToLower() == "true" ;
                    
                    if (numeDinFisier == nume && parolaDinFisier == parola)
                    {
                        esteAdmin = statusAdmin;
                        Console.WriteLine($"Autentificare reusita!{(esteAdmin ? "Administrator":"Utilizator Obisnuit")}");
                        return true;
                    }
                }

            }
                Console.WriteLine("Nume sau Parola gresite!");
                return false;





        }
    }
}
