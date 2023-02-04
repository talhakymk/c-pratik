using System;

namespace test
{

    class Program 
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("isminizi girin");
            string? isim = Console.ReadLine();
            Console.WriteLine("soyisminizi girin");
            string? suyisim = Console.ReadLine();
            
            Console.WriteLine("merhaba " + isim + " " + suyisim);
        }
    }
}

