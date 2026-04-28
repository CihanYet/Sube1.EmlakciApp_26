using System;
using System.IO;//Input/Output



namespace Sube1.EmlakciLib
{
    public class Ev
    {
        private static int sayac = 0;//static üyeler class'a aittir.
        public static int Sayac { get => sayac; }

        public Ev()
        {
            sayac++;
        }
        public Ev(int odasayisi, int katno, string semt, double alan)
        {
            sayac++;
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.SetAlan(alan);
        }
        public Ev(int odasayisi, int katno, double alan)
        {
            sayac++;
            this.alan = alan;
            this.odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Gazi";
        }

        private int odasayisi;

        private string semt;//field
        private double alan;
        private string buyukluk;

        public int Katno { get; set; }//Auto Property- Get ve set içerisinde işlem yapılamayacaksa kullanılır.
        public string Semt { get => semt; set => semt = value.ToUpper(); }//Property-Get ve set içinde tek satırlı işlem


        public int Odasayisi//Full Property- Get ve Set içinde çok satırlı işlem imkanı
        {
            get
            {
                return this.odasayisi;
            }
            set
            {
                this.odasayisi = Math.Abs(value);
                if (odasayisi < 0)
                {
                    Log("Oda sayısı negatif girildi", @"C:\CihanHoca\Sube1Log.txt");
                }
            }
        }





        //Alan fieldına atanan değere göre buyukluk field'ına değerler atanacak.
        //50-75:Küçük ev
        //75-120:Orta ev
        //>120 : Büyük ev

        public void SetAlan(double alan)
        {
            this.alan = alan;
            if (alan > 50 && alan < 75)
            {
                this.buyukluk = "Küçük Ev";
            }
            else if (alan > 75 && alan < 120)
            {
                this.buyukluk = "Orta Ev";
            }
            else
            {
                this.buyukluk = "Büyük Ev";
            }
            //50'den küçük olma durumu değerlendirilecek.
        }

        public double GetAlan() => alan;

        public string GetBuyukluk() => buyukluk;

        public void SetSemt(string semt) => this.Semt = semt.ToUpper();
        public string GetSemt() => this.Semt;



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
            return $"Oda Sayısı:{this.odasayisi}\nKat No:{this.Katno}\nSemt:{this.Semt}\nAlan:{this.alan}m2\nBüyüklük:{this.buyukluk}";
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

//1- Metodlar
//// İç içe yazılmaz
//// Tekrar kullanılabilir
//// İş yapmak için kullanılır
//// Classların içinde tanımlanır
//// ErişimBelirleyici GeriDonusTipi MetodAdi(param1,param2,....)
//// Her metod parametre almak zorunda değil
//// Parametre: Bir metodun işini yapabilmesi için gerekli veriler.
//// Opsiyonel Parametre: Değer göndermek zorunda olmadığımız parametreler.Metoda değer gönderirken köşeli parantezler içinde gözükür. Aynı zamanda default değeri de gözükür.
//// Geri dönüş yapmayan metodlar void tipi ile tanımlanır
//// Method Overloading: Bir class içerisinde aynı isimli metodlar imzaları farklı olarak tanımlanabilir. 
//// Metod imzası: Metodların aldığı parametrelerin sayısı ve veri tipleri. Metodlar için önemli tanımlayıcılardır.

//.NET
////Kütüphaneler
////Programlama Dilleri (C#,VB,F#)
////IDE(Visual Studio) Kod Editorü(VS Code)
////.NET Framework - .NET(Core) - Xamarin
////.NET Standart:TÜm .net frameworklerinde kullanılabilen bir .net framework'üdür. Örn. bir class library'i .net standart ile yaparsak diğer tüm framewroklerde kullanılabilir. NOT: Sürüm uyumu önemli
//// C# App -> Derleme(Build) -> MS-IL -> Runtime ile derleme -> Binary(0-1)

//Class
//// Kod tekrarını engeller
//// Nesne oluştururlur. Nesnelerin temelidir
//// Bir nesnenin içereceği özellikleri ve davranışları belirler
//// Bir classtan nesne olusturmak için new anahtar sözcüğü kullanılır.
//// Nesneler belleğin HEAP alanında tutulur. Nesne referansları STACK bölgesinde

//Constructor
//// Default Constructor: Her classta vardır. public'dir. Class içinde tanımlanan field'lara varsayılan değerlerini atar.
//// Constructor Overloading: Nesne türetilirken, fieldlara kendi istediğimiz değerleri atamak için kullanılabilir.
//// Tanımlanması: Geri dönüş tipi yoktur.Adı class adıyla aynı olmalıdır.

//Kapsülleme
////Class içinde yapılan işlemlerin, class dışından gizlenmesidir. Güvenlik, bir fielda değer geldiğinde başka işlemler yapma vb. gibi sebeple kullanılır. 
////Bu ilkeye göre fieldlar private olmalıdır.
////Private fieldlara class dışından erişmek için, public 2 metod yazılır. GET ve SET metodları.
///
//static üyeler class'a aittir. Class adı ile erişilir.Program çalıştığı sürece bellekte kalır.