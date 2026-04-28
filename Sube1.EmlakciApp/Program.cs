using Sube1.EmlakciLib;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var evim = new Ev();
            // Console.WriteLine("Oda sayısı giriniz:");
            //evim.SetOdaSayisi(int.Parse(Console.ReadLine()));

            // //int sayi = 5;//SET
            // //Console.WriteLine(sayi);//GET
            // //evim.semt = "Gazi";

            // Console.WriteLine(evim.GetOdaSayisi());
            // //Console.WriteLine(evim.EvBilgileri());
            // Console.ReadKey();

            // evim.Semt = "Gazi";
            // Console.WriteLine(evim.Semt);


            //Ev evim = new Ev();

            //Ev evim2 = new Ev();
            //Ev evim3 = new Ev(2, 2, 120);

            //Ev.Sayac = 5;

            //Console.WriteLine($"Bellekteki Ev Sayısı:{Ev.Sayac}");

            var se = new SatilikEv();
            se.Semt = "Gazi";
            se.SetAlan(100);
            se.Katno = 2;
            se.Odasayisi = 3;
            se.Satisfiyat = 100000;

            Console.WriteLine(se.EvBilgileri());

        }
    }
}

//null: değersiz
//Class'lar referans tipi veri tipleridir.Referans tipleri veriler, HEAP bölgesinde tutulur ve null değer alabilirler. Null referanslar üstünden işlem yapılırsa, Runtime sırasında NullReferenceException hatası alınır.
//Constructor-Yapıcı Metod-Kurucu Metod: Class içinde tanımlanan field'lara varsayılan değer atamasını yapan metodlardır. Bu metodlar class içinde her zaman bulunurlar. Bir classtan nesne türetilir türetilmez çalışan ilk metoddur.