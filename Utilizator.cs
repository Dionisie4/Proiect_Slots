using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Slots
{
    class Utilizator
    {
        private string nume;
        private string parola;
        private int balanta;
        private bool esteAdmin;
        

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value.Length <= 10)
                {
                    nume = value;
                }
                else
                {
                    throw new ArgumentException("Numele trebuie să fie de maxim 10 caractere!");
                }
            }
        }

        public string Parola
        {
            get { return parola; }
            protected set { parola = value; }
        }

        public bool EsteAdmin
        {
            get { return esteAdmin; }
            private set { esteAdmin = value; }
        }
        public int Balanta
        {
            get { return balanta; }
            set
            {
                if (value >= 0)
                {
                    balanta = value;
                }
                else
                {
                    throw new ArgumentException("Balanta nu poate fi negativa!");
                }
            }
        }
        


        public Utilizator (string Nume, string Parola, bool EsteAdmin, int Balanta)
        {
            nume = Nume;
            parola = Parola;
            esteAdmin = EsteAdmin;
            balanta = Balanta;
           
        }

        public void SeteazaBalanta(int valoare)
        {
            if (valoare >= 0)
            {
                balanta = valoare;
            }
            else
            {
                throw new ArgumentException("Balanta nu poate fi negativa!");
            }
        }

        public void ActualizeazaBalanta(int castig)
        {
            Balanta += castig;
        }

    }
}

