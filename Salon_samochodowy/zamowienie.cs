using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_samochodowy
{
    class zamowienie
    {
        public string model;
        public string kolor;
        public Wyposazenie wyposazenie;
        public int cenaPodstawowa;
        public int cenaKoncowa;
        public Klient klient;
    }
    class Wyposazenie
    {
        public bool opcja1;
        public bool opcja2;
        public bool opcja3;
        public bool opcja4;
        public string kolor;
    }
}
