using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class GraKomp
    {
        public string Nazwa { get; set; }
        public string Gatunek { get; set; }
        public int Wiek { get; set; }
        public bool Multiplayer { get; set; }
        public int Indeks {get; set;}
        public static int Gry = 0;

        public GraKomp(string nazwa, string gatunek, int wiek, bool multiplayer)
        {
            Nazwa = nazwa;
            Gatunek = gatunek;
            Wiek = wiek;
            Multiplayer = multiplayer;
            Gry++;
            Indeks= Gry;
        }
    }
}
