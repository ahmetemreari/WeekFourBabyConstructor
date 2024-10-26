//Bebek adlı sınıf oluştur
//Bebek sınıfının propertyleri -> Doğum Tarihi , Ad , Soyad 
//Bebek sınıfı için 2 adet constructor tanımlayınız.
//1.si Default Constructor tarzında parametre almayan bir metot.
//2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.
//2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda;
//konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.

using System;

namespace BebekUygulamasi
{
    class Bebek
    {
        //propertyler
        public DateTime Dogum { get; set; }
        public string Ad { get; set; } = string.Empty; // Varsayılan değer atandı
        public string Soyad { get; set; } = string.Empty; // Varsayılan değer atandı

        //Default Constructor
        public Bebek()
        {
            Dogum = DateTime.Now; // Doğum tarihi o anki tarih olacak
            Console.WriteLine("Ingaaaa"); // Ingaaaa yazısı konsola yazılacak
        }

        //Parametre alan constructor
        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            Dogum = DateTime.Now; // Doğum tarihi o anki tarih olacak
            Console.WriteLine("Ingaaaa"); // Ingaaaa yazısı konsola yazılacak
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //String tanımlama ve kullanım
            Bebek bebek1 = new Bebek();
            string bebek1Ad = "Mehmet";
            string bebek1Soyad = "Karahanlı";    
            //String ile yazdırdım 
            
            Console.WriteLine($"Bebek Adı : {bebek1Ad} Soyadı : {bebek1Soyad} , D.T : {bebek1.Dogum}");

         
            //TOTAL
            Bebek bebek2 = new Bebek("Efe","Karahanlı");
            Bebek bebek3 = new Bebek("Polat","Alemdar");
            Bebek bebek4 = new Bebek("Abdülhey","Çoban");
            Bebek bebek5 = new Bebek("Memati", "Baş");
            Bebek bebek6 = new Bebek("Süleyman", "Çakır");
            // bebek listesi
            Bebek[] bebekler = { bebek2,bebek3,bebek4, bebek5, bebek6 };
            // bebek listesini yazdır
            foreach (var bebek in bebekler)
            {
                Console.WriteLine($"Bebek Adı : {bebek.Ad}  Soyadı : {bebek.Soyad} ,  D.T : {bebek.Dogum}  \nINGA INGA");
            }
        }
    }
}
