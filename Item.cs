using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_Slots
{
    public class Item
    {
        public string Nume { get; set; }      // numele simbolului
        public string Simbol { get; set; }    //simbol
        public int Multiplicator { get; set; } // multiplicator
        public int Sanse { get; set; }        // probabilitatea 

        public Item(string nume, string simbol, int multiplicator, int sanse)
        {
            Nume = nume;
            Simbol = simbol;
            Multiplicator = multiplicator;
            Sanse = sanse;
        }
    }
}