using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Eğitmen = "Hasan Altın";
            kurs1.İzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Eğitmen = "kerem";
            kurs2.İzlenmeOrani = 63;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Eğitmen = "berkay";
            kurs3.İzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);

            }



            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Eğitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
