using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class KiralikEv : Ev
    {

        public KiralikEv()
        {

        }

        public KiralikEv(int odasayisi, int katno, string semt, double alan, double depozito, double kira) : base(odasayisi, katno, semt, alan)
        {
            this.Depozito = depozito;
            this.Kira = kira;
        }
        public double Kira { get; set; }
        public double Depozito { get; set; }

        public string EvBilgileri() => $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
    }
}
