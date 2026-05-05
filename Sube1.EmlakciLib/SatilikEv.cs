using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {
            
        }

        //public SatilikEv(int odasayisi,int katno,string semt,double alan,double satisfiyat)
        //{
        //    this.Satisfiyat = satisfiyat;
        //    base.Odasayisi = odasayisi;
        //    base.Katno = katno;
        //    base.Semt = semt;
        //    base.SetAlan(alan);
        //}

        public SatilikEv(int odasayisi, int katno, string semt, double alan, double satisfiyat):base(odasayisi,katno, semt, alan) 
        {
            this.Satisfiyat = satisfiyat;            
        }

        public double Satisfiyat { get; set; }

        public new string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
        }
    }
}

//internal: Aynı namespace içerisindeki diğer classlardan erişilebilir üyeler tanımlamak için kullanılır.

//Name Hiding:Türeyen class içerisinde, base classtaki ile aynı isimli bir üye tanımlanırsa, türeyen class referansı ile artık base classtaki üyeye erişilemez. Base classtaki üye gizlenir.