using System;
using System.Threading.Channels;

namespace ElatkozottBurok
{
    public class Nassolnivalo
    {
        Random rnd = new Random();

        private string nev;
        private int koffeinLoket;
        private int stresszOldas;
        private int ar;

        public Nassolnivalo(string nev, int koffeinLoket, int stresszOldas, int ar)
        {
            this.Nev = nev;
            this.KoffeinLoket = koffeinLoket;
            this.StresszOldas = stresszOldas;
            this.Ar = ar;
        }

        public string Nev
        {
            get => nev;
            set
            {
                if (value == "" || value == null)
                {
                    nev = "Ismeretlen nassolnivaló";
                }
                else { nev = value; }
            }
        }
        public int KoffeinLoket
        {
            get => koffeinLoket;
            set
            {
                if (value < 0)
                {
                    koffeinLoket = 0;
                }
                else if (value > 50)
                {
                    koffeinLoket = 50;
                }
                else { koffeinLoket = value; }
            }
        }
        public int StresszOldas
        {
            get => stresszOldas;
            set
            {
                if (value < 0)
                {
                    stresszOldas = 0;
                }
                else if (value > 50) { stresszOldas = 50; }

                else { stresszOldas = value; }
            }
        }
        public int Ar
        {
            get => ar;
            set
            {
                if (value < 100)
                {
                    ar = 100;
                }
                else { ar = value; }

            }
        }
    }
}