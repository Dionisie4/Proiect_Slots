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
        private int zileDeLaUltimaLogare;
        

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

        public int Balanta
        {
            get { return balanta; }
            protected set { balanta = value; }
        }
        public int ZileDeLaUltimaLogare
        {
            get { return zileDeLaUltimaLogare; }
            private set { zileDeLaUltimaLogare = value; }
        }

        public Utilizator (string Nume, string Parola, int Balanta, int ZileDeLaUltimaLogare)
        {
            nume = Nume;
            parola = Parola;
            balanta = Balanta;
            zileDeLaUltimaLogare = ZileDeLaUltimaLogare;
        }

    }
}

