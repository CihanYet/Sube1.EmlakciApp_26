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

        private int odasayisi;
        public int katno;
        public string semt;
        public double alan;

        public void SetOdaSayisi(int odasayisi)
        {
            //if (odasayisi < 0)
            //{
            //    this.odasayisi = -odasayisi;
            //}
            //else
            //{
            //    this.odasayisi = odasayisi;
            //}

            this.odasayisi = Math.Abs(odasayisi);
        }

        public int GetOdaSayisi()
        {

            return this.odasayisi;
        }

        public string EvBilgileri()
        {
            return $"Oda Sayısı:{this.odasayisi}\nKat No:{this.katno}\nSemt:{this.semt}\nAlan:{this.alan}m2";
        }
    }
}

//Kapsülleme(Encapsulation) İlkesi: Class içerisinde yapılan işlemlerin class dışından gizlenmesi.Örn: SetOdaSayisi metoduna değer gönderildiğinde, bu metod aldığı değerin mutlka değerini alarak odasayisi field'ına atama yapıyor. Bu durum class dışından farkedilemiyor.
