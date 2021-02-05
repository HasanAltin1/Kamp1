using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urun1Adi = "Elma";
            double fiyati1 = 15;
            string aciklama1 = "Amasya Elması";

            string urun2Adi = "Çilek";
            double fiyati2 = 5;
            string aciklama2 = "çilekler";


            string[] meyveler = new string[] { };


            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "çilek";
            urun2.Fiyati = 5;
            urun2.Aciklama = "çilekler";

            Urun[] urunler = new Urun[] {urun1,urun2};


            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("..........................");


            }

            Console.WriteLine("-------Metodlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil", 12, 2);
            sepetManager.Ekle2("elma", "yeşil", 12, 6);
            sepetManager.Ekle2("karpuz", "diyarbakır", 12,  9);

        }
    }
}
