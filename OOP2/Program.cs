using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //musteri1 hasan
            //musteri musteri1 = new musteri();
            // musteri1.adi = "hasan";          
            //musteri1.soyadi = "altin";
            //musteri1.ıd = 1;
            //musteri1.tcno = "123212432";
            //musteri1.musterino = "23583458346";
            // musteri1.sirketadi = "?";


            //gerçek müşteri - tüzel müşteri

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "123455";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "1232341434";


            //Tuzel musteri = Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "121414";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";




            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
        }  
    }
}
