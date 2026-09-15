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

        public Fejleszto(string nev, Munkakor munkakor, int penz, int koffeinSzint, int stresszSzint, bool kiegve, string kedvencSnack)
        {
            this.nev = nev;
            this.munkakor = munkakor;
            this.penz = penz;
            this.koffeinSzint = koffeinSzint;
            this.stresszSzint = stresszSzint;
            this.kiegve = kiegve;
            this.kedvencSnack = kedvencSnack;
        }

        public string Nev { get => nev; set => nev = value; }
        public Munkakor Munkakor { get => munkakor; set => munkakor = value; }
        public int Penz { get => penz; set => penz = value; }
        public int KoffeinSzint { get => koffeinSzint; set => koffeinSzint = value; }
        public int StresszSzint { get => stresszSzint; set => stresszSzint = value; }
        public bool Kiegve { get => kiegve; set => kiegve = value; }
        public string KedvencSnack { get => kedvencSnack; set => kedvencSnack = value; }
    }
}