using System;

namespace _8_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz!");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i% 2 == 1)
                Console.WriteLine(i);    
            }
            //1 ile 1000 arasındaki tek ve çift sayıların kendi içerisindeki toplamlarını yazdır.
            
            int cifttoplam = 0;
            int tektoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tektoplam += i; // tektoplam = tektoplam + i
                else
                    cifttoplam += i; // cifttoplam = cifttoplam + i

            }
            Console.WriteLine("Tektoplam: " + tektoplam);
            Console.WriteLine("cifttoplam: " + cifttoplam);

            // Break, Continue

            for (int i = 1; i <= 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);

            }
              for (int i = 1; i <= 10; i++)
            {
                if (i==4)
                    continue;
                Console.WriteLine(i);

            }

        }
    }
}
