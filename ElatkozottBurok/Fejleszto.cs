using System;
using System.Diagnostics.Tracing;

namespace ElatkozottBurok
{
    public class Fejleszto
    {
        private string nev;
        private Munkakor munkakor;
        private int penz;
        private int koffeinSzint;
        private int stresszSzint;
        private bool kiegve;
        private string kedvencSnack;

        public Fejleszto(string nev, Munkakor munkakor, int penz, string kedvencSnack, int koffeinSzint = 100, int stresszSzint = 100)
        {
            this.Nev = nev;
            this.Munkakor = munkakor;
            this.Penz = penz;
            this.KoffeinSzint = koffeinSzint;
            this.StresszSzint = stresszSzint;
            this.KedvencSnack = kedvencSnack;
        }

        public string Nev { get => nev; set => nev = value; }
        public Munkakor Munkakor { get => munkakor; set => munkakor = value; }
        public int Penz { 
            get => penz; 
            set {
                if (penz < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(penz), "Pénz nem lehet 0-nál kevesebb.");
                }
                else { penz = value; }
            }
        }
        public int KoffeinSzint { 
            get => koffeinSzint; 
            set { 
                if (value <= 0)
                {
                    koffeinSzint = 0;
                }
                else if (value >= 100)
                {
                    koffeinSzint = 100;
                    kiegve = true;
                }
                else { koffeinSzint = value; }
            } 
        }
        public int StresszSzint { 
            get => stresszSzint; 
            set {
                if (value <= 0)
                {
                    stresszSzint = 0;
                }
                else if (value >= 100)
                {
                    stresszSzint = 100;
                    kiegve = true;
                }
                else { stresszSzint = value; }
            } 
        }
        public bool Kiegve { get => kiegve; set => kiegve = value; }
        public string KedvencSnack { get => kedvencSnack; set => kedvencSnack = value; }

        private void Dolgozik()
        {
            if (kiegve = true)
            {
                Console.WriteLine("A dolgozó ki van égve.");
            } 
            //else if (munkakor = Munkakor.Junior)
            //{

            //}
             
        }
    }
}