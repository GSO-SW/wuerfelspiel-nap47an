using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        int letztesErgebnis;
        bool gesichert;
        Random md;

        public Wuerfel()
        {

        }

        public Wuerfel(int anzahlSeiten)
        {

        }

        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }

        public int LetztesErgebnis
        {
            get
            {
                return letztesErgebnis;
            }
        }

        public bool Gesichert
        {
            get
            {
                return gesichert;
            }
            set
            {
                gesichert = Gesichert;
            }
        }

        public void SicherungUmschalten()
        {

        }

        public int Wuerfeln()
        {
            letztesErgebnis = md.Next(0, 7);
            return letztesErgebnis;
        }
    }
}
