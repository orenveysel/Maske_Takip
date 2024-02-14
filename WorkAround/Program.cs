using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Veysel");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrenci1 = "Veysel";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Veysel";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir"};
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "DONALD";
            person1.LastName = "TRUMP";
            person1.DateOfBirthYear = 1905;
            person1.NationalIdentity = 12345678910;  //replace this fake data of person1 with real data for identity check

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        //resharper
        static void SelamVer(string isim="NoName")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000.5; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Veysel";
            string soyad = "ÖREN";
            int dogumYili = 1998;
            long tcNo = 12345678910;


            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}



// Single-Responsibility Principle

//ÖZET: Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir,
//o da o sınıfa yüklenen sorumluluktur,
//yani bir sınıfın(fonksiyona da indirgenebilir) yapması gereken yalnızca bir işi olması gerekir.


// Open-Closed Principle

//ÖZET: Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir.
//Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.


// Liskov Substitution Principle

//ÖZET: Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, 
//türedikleri(üst) sınıfların yerine kullanabilmeliyiz.


// Interface Segregation Principle

//ÖZET: Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.


// Dependency Inversion Principle

//ÖZET: Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.

