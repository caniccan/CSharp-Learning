using System;

namespace console_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Adınızı Giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name +" " + surname);

            Console.ReadKey();
        }
    }
}
