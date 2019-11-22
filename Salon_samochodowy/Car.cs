using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_samochodowy
{
    class Car
    {
        public string nazwaBazySamochodow;
        List<string> nazwaModelu = new List<string>();
        List<string> listaKolorow = new List<string>(); // #0000000,#C0C0C0, itp
        List<bool> czyWSprzedazy = new List<bool>();
        List<Wyposazenie_Car> listaMozliwegoWyposazenia = new List<Wyposazenie_Car>();
        List<int> cenaPodstawowa = new List<int>();

        public Car(string nazwaBazySamochodow)
        {
            this.nazwaBazySamochodow = nazwaBazySamochodow;
        }
        public void DodajModel(string nazwaModelu,string _listaKolorow,bool _czyWSprzedazy, int cena, Wyposazenie_Car mozliweWyposazenie)
        {
            this.nazwaModelu.Add(nazwaModelu);
            this.listaKolorow.Add(_listaKolorow);
            this.czyWSprzedazy.Add(_czyWSprzedazy);
            this.listaMozliwegoWyposazenia.Add(mozliweWyposazenie);
            this.cenaPodstawowa.Add(cena);
        }
        public void EdytujModel(string _nazwaModelu, string _listaKolorow, bool _czyWSprzedazy,int cena, Wyposazenie_Car mozliweWyposazenie)
        {
            int id = IDModelu(_nazwaModelu);
            if (id != -1)
            {
                this.listaKolorow[id] = _listaKolorow;
                this.czyWSprzedazy[id] = _czyWSprzedazy;
                this.listaMozliwegoWyposazenia[id] = mozliweWyposazenie;
                this.cenaPodstawowa[id] = cena;
            } else
            {
                MessageBox.Show("Nie znaleziono podanego modelu samochodu!");
            }
        }
        public int IDModelu (string _nazwaModelu)
        {
            int i = 0;
            foreach (string nazwa in this.nazwaModelu)
            {
                if (nazwa == _nazwaModelu)
                {
                    return i;

                }
                i++;
            }
            return -1;
        }
        public List<string> WygenerujListeKolorowDlaModelu (string _nazwaModelu)
        {
            int id = IDModelu(_nazwaModelu);
            List<string> kolory = new List<string>();
            if (id != -1)
            {
                string[] tmpStr = this.listaKolorow[id].Split(',');
                foreach (string kolor in tmpStr)
                {
                    kolory.Add(kolor);
                }
                return kolory;
            }
            else
            {
                return kolory;
            }
        }
        public bool CzyWSprzedazyModel(string _nazwaModelu)
        {
            int id = IDModelu(_nazwaModelu);
            if (id != -1)
            {
                if (this.czyWSprzedazy[id] == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public int CenaPodstawowaModelu(string _nazwaModelu)
        {
            int id = IDModelu(_nazwaModelu);
            if (id != -1)
            {
                return this.cenaPodstawowa[id];
            }
            else
            {
                return 0;
            }
        }
    }
    class Wyposazenie_Car
    {
        public bool opcja1; //czy 1 opcja wyposazenia jest mozliwa w tym modelu ? itp
        public bool opcja2;
        public bool opcja3;
        public bool opcja4;
        List<string> listaKolorowWnetrza = new List<string>(); // listaKolorw wnetrza 
    }
}
