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
                else { nev = value; }
            }
        }
        public int KoffeinLoket { 
            get => koffeinLoket; 
            set {
                if (koffeinLoket < 0)
                {
                    koffeinLoket = 0;
                }
                else if (koffeinLoket > 50)
                {
                    koffeinLoket = 50;
                }
                else { koffeinLoket = value; }
            } 
        }
        public int StresszOldas { 
            get => stresszOldas; 
            set {
                if (stresszOldas < 0 || stresszOldas > 30)
                {
                    Console.WriteLine("Stressz csökkentés 0 és 30 között lehet.");
                }
                else {  stresszOldas = value; }
            }
        }
        public int Ar { 
            get => ar; 
            set {
                if (ar  < 100)
                {
                    Console.WriteLine("Az árnak minimum 100-nka kell lennie.");
                }
                else { ar = value;  }
                
            } 
        }
    }
}