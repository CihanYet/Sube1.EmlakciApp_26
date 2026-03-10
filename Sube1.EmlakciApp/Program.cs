using Sube1.EmlakciLib;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev evim = new Ev(3, 2, "Gazi", 100);
            Console.WriteLine(evim.EvBilgileri());                       

            var evim4 = new Ev(3, 5, 120);

            string bilgi = evim4.EvBilgileri();
            Console.WriteLine(bilgi);
            //Console.WriteLine(evim4.EvBilgileri());            
           
        }
    }



  
}

//null: değersiz
//Class'lar referans tipi veri tipleridir.Referans tipleri veriler, HEAP bölgesinde tutulur ve null değer alabilirler. Null referanslar üstünden işlem yapılırsa, Runtime sırasında NullReferenceException hatası alınır.
//Constructor-Yapıcı Metod-Kurucu Metod: Class içinde tanımlanan field'lara varsayılan değer atamasını yapan metodlardır. Bu metodlar class içinde her zaman bulunurlar. Bir classtan nesne türetilir türetilmez çalışan ilk metoddur.