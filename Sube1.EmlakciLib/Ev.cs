using System;
using System.IO;//Input/Output



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
        private string semt;
        private double alan;
        private string buyukluk;

        //Alan fieldına atanan değere göre buyukluk field'ına değerler atanacak.
        //50-75:Küçük ev
        //75-120:Orta ev
        //>120 : Büyük ev

        public void SetAlan(double alan)
        {  
            this.alan = alan;
            if (alan>50&&alan<75)
            {
                this.buyukluk = "Küçük Ev";
            }
            else if (alan>75&&alan<120)
            {
                this.buyukluk = "Orta Ev";
            }
            else
            {
                this.buyukluk = "Büyük Ev";
            }
            //50'den küçük olma durumu değerlendirilecek.
        }

        public void SetSemt(string semt) => this.semt = semt.ToUpper();
        public string GetSemt() => this.semt;



        public void SetOdaSayisi(int odasayisi)
        {
            this.odasayisi = Math.Abs(odasayisi);
            if (odasayisi < 0)
            {
                Log("Oda sayısı negatif girildi", @"C:\CihanHoca\Sube1Log.txt");
            }
        }

        public int GetOdaSayisi() => this.odasayisi;

        public string EvBilgileri()
        {
            Log("Ev bilgileri alındı", @"C:\CihanHoca\Sube1Log.txt");
            return $"Oda Sayısı:{this.odasayisi}\nKat No:{this.katno}\nSemt:{this.semt}\nAlan:{this.alan}m2\nBüyüklük:{this.buyukluk}";
        }

        public void Log(string msg, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{DateTime.Now}-{msg}");
            fs.Flush();
            sw.Close();
            fs.Close();
            //Dispose işlemine bakılacak.
        }
    }
}

//Kapsülleme(Encapsulation) İlkesi: Class içerisinde yapılan işlemlerin class dışından gizlenmesi.Örn: SetOdaSayisi metoduna değer gönderildiğinde, bu metod aldığı değerin mutlka değerini alarak odasayisi field'ına atama yapıyor. Bu durum class dışından farkedilemiyor.
