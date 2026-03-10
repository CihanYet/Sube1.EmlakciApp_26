using System;

namespace Sube1.EmlakciLib
{
    public class Ev
    {
        public Ev()
        {

        }
        public Ev(int odasayisi, int katno, string semt, double alan)
        {
            this.odasayisi = odasayisi;
            this.katno = katno;
            this.semt = semt;
            this.alan = alan;
        }
        public Ev(int odasayisi, int katno, double alan)
        {
            this.alan = alan;
            this.odasayisi = odasayisi;
            this.katno = katno;
            this.semt = "Gazi";
        }

        public int odasayisi;
        public int katno;
        public string semt;
        public double alan;

        public string EvBilgileri()
        {
            return $"Oda Sayısı:{this.odasayisi}\nKat No:{this.katno}\nSemt:{this.semt}\nAlan:{this.alan}m2";
        }
    }
}
