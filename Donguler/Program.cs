using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılımcı yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç kursu";
            string kurs3 = "java";


            //array = dizi

            string[] kurslar = new string[] { "yazılımcı yetiştirme kampı",
                "programlamaya başlangıç kursu", 
                "java","python" , "c#"};





            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti"); 

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs); 
            }

            Console.WriteLine("sayfa sonu");

        }
    }
}
