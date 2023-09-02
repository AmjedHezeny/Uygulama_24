using System;
using System.Collections.Generic;
using System.Linq;

namespace Uygulama_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Metodlar> kisiler = new List<Metodlar>()
            {
                new Metodlar() {ad = "Ahmet", soyad = "Kaçar", sehir = "İzmir", yas = 30 },
                new Metodlar() {ad = "Ayşe", soyad = "Sarı", sehir = "İzmir", yas = 25 },
                new Metodlar() {ad = "Mehmet", soyad = "Yılmaz", sehir = "Ankara", yas = 35 },
                new Metodlar() {ad = "Halil", soyad = "Sönmez", sehir = "Manisa", yas = 28 },
                new Metodlar() {ad = "Fatma", soyad = "Sönmez", sehir = "Tokat", yas = 45 },
                new Metodlar() {ad = "Elif", soyad = "Taşçı", sehir = "Bilecik", yas = 22 },
                new Metodlar() {ad = "Elif", soyad = "Bilgin", sehir = "İstanbul", yas = 29 },
                new Metodlar() {ad = "Elif", soyad = "Çetiner", sehir = "İstanbul", yas = 30 },
                new Metodlar() {ad = "Ahmet", soyad = "Kaçar", sehir = "İstanbul", yas = 33 },
                new Metodlar() {ad = "Hakan", soyad = "Uysal", sehir = "Ankara", yas = 40 },
                new Metodlar() {ad = "Leyla", soyad = "Kabakçı", sehir = "Zonguldak", yas = 27 },
                new Metodlar() {ad = "Ali", soyad = "Yılmaz", sehir = "İstanbul", yas = 28  },
                new Metodlar() {ad = "Selma", soyad = "Demir", sehir = "Ankara", yas = 32 }
            };

            #region Orderby(asc)

            Console.WriteLine("*******************************************************");
            Console.WriteLine("OrderBy Metod\r\nVerileri küçükten büyüğe doğru sıralamak Classic olarak");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            var kbListe = from k in kisiler
                          orderby k.ad ascending
                          select k;
            foreach (var item in kbListe)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();



            Console.WriteLine("*******************************************************");
            Console.WriteLine("OrderBy Metod\r\nVerileri küçükten büyüğe doğru sıralamak");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            var kbListe2 = kisiler.OrderBy(k => k.ad);
            foreach (var item in kbListe2)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            #endregion



            Console.WriteLine("*******************************************************");
            Console.WriteLine("OrderByDescending Metod\r\nverileri ad a göre alfabetik, soyad a göre alfabetik ters sıralama Classic olarak");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            Console.WriteLine();
            #region OrderByDescending
            var bkListe = from x in kisiler
                          orderby x.ad descending
                          select x;
            foreach (var item in bkListe)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("*******************************************************");
            Console.WriteLine("OrderByDescending Metod\r\nverileri ad a göre alfabetik, soyad a göre alfabetik ters sıralama Yapar");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();


            var bkListe2 = kisiler.OrderByDescending(x => x.ad);
            foreach (var item in bkListe2)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            #endregion



            #region ThenBy veya ThenByDescending
            Console.WriteLine("*******************************************************");
            Console.WriteLine("ThenByDescending Metod\r\nVerileri ad a göre alfabetik, soyad a göre alfabetik ters sıralamk Classic olarak");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            var kbAListe = from o in kisiler
                           orderby o.ad ascending, o.soyad descending
                           select o;
            foreach (var item in kbAListe)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("*******************************************************");
            Console.WriteLine("ThenByDescending Metod\r\nVerileri ad a göre alfabetik, soyad a göre alfabetik ters sıralamk");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            var kbAListe2 = kisiler.OrderBy(o => o.ad).ThenByDescending(o => o.soyad);
            foreach (var item in kbAListe2)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region Where
            Console.WriteLine("*******************************************************");
            Console.WriteLine("where Metod\r\nKoleksiyon içerisinde şehri İstanbul olan kişileri listeleyelim Classic olarak");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            var fListe = from k in kisiler
                         where k.sehir.ToLower() == "istanbul"
                         select k;
            foreach (var item in fListe)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("*******************************************************");
            Console.WriteLine("where Metod\r\nKoleksiyon içerisinde şehri İstanbul olan kişileri listeleyelim Classic olarak");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            var fListe2 = kisiler.Where(k => k.sehir.ToLower() == "istanbul");
            foreach (var item in fListe2)
            {
                item.Yazdir();
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
            #endregion


            #region GroupBy

            Console.WriteLine("*******************************************************");
            Console.WriteLine("GroupBy Metod\r\nKoleksiyon içerisindeki verileri şehir bilgisine göre gruplayalım Classic olarak");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            var gListe = kisiler.GroupBy(g => g.sehir);
            foreach (var grup in gListe)
            {
                Console.WriteLine(grup.Key);
                Console.WriteLine("*******************************************************");
                foreach (var item in grup.OrderBy(k => k.ad))
                {
                    item.Yazdir();
                }
                Console.WriteLine("*******************************************************");
                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }
    }
}