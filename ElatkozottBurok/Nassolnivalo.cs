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

        public Nassolnivalo(string nev, int stresszOldas, int ar, int koffeinLoket)
        {
            this.nev = nev;
            this.koffeinLoket = koffeinLoket;
            this.stresszOldas = stresszOldas;
            this.ar = ar;
        }

        public string Nev { 
            get => nev;
            set {
                if (nev == "" || nev == null)
                {
                    nev = "Ismeretlen nassolnivaló";
                } 
                else
                {
                    nev = value;
                }
            }
        }
        public int KoffeinLoket { 
            get => koffeinLoket; 
            set {
                if (koffeinLoket < 0 || koffeinLoket > 50)
                {
                    Console.WriteLine("Koffein szintnek 0 és 50 között kell lennie.");
                }
                else
                {
                    koffeinLoket = value;
                }
            } 
        }
        public int StresszOldas { 
            get => stresszOldas; 
            set {
                stresszOldas = value; 
            }
        }
        public int Ar { get => ar; set => ar = value; }
    }
}