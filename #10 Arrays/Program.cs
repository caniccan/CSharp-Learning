using System;

namespace _10_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atama ve erişim
            renkler[0]= "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3]=10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngüler ile dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayıdizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayıdizisi[i]= int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayıdizisi)
                toplam += sayi;
            
            Console.WriteLine("Ortalama: "+ toplam/diziuzunlugu);
            Console.ReadKey();
            
        }
    }
}
