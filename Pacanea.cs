using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Slots
{
    class Pacanea
    {
        private int mizaCurenta;
        private static readonly List<int> MizePermise = new List<int> { 1, 2, 3, 5, 10, 20 };
        
        public void SeteazaMiza(int valoare)
        {
            bool ValoareCorecta = false;

            if (MizePermise.Contains(valoare))
            {
                mizaCurenta = valoare;
            }
            else
            {
                throw new ArgumentException($"Valoarea mizei este incorecta, miza trebuie sa fie una din urmatoarele valori: {string.Join(", ", MizePermise)}");               
            }



        }

    }

}
