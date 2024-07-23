using System;

namespace KullaniciBilgileri
{
    class Program
    {
        static void Main()
        {
            // Kullanıcıdan bilgileri almak için sorular soruyoruz.

            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");


            // Soruları sorarken cevapların aynı satırda görüntülenmesi için Console.Write ile yazdım.
            // T.C. kimlik no ile matematiksel işlem yapılmayacağı için string veri tipi kullandım.

            Console.Write("T.C. Kimlik Numarası: ");
            string tcKimlikNo = Console.ReadLine();


            Console.Write("Adı: ");
            string adi = Console.ReadLine();


            Console.Write("Soyadı: ");
            string soyadi = Console.ReadLine();


            // Telefon numarasıyla matematiksel işlem yapılmayacağı için string veri tipi ile yazdım.
            Console.Write("Telefon Numarası: ");
            string telefonNumarasi = Console.ReadLine();


            // Yaş sorusuna rakamsal değerler dışında cevap verilmemesi ve yazılanları tek tek karakter olarak değil tam sayı olarak okuması için int veri tipini kullandım.
          
            Console.Write("Yaş: ");
            int yas = Convert.ToInt32(Console.ReadLine());


            // decimal --> parasal değerler vs.
            /* float --> fiziksel tam sayılar yani yer çekimi, pi sayısı vs.
             * double --> geometrik değerler vs.
             */

            Console.Write("İlk aldığı ürünün fiyati: ");
            decimal ilkUrunFiyati = Convert.ToDecimal(Console.ReadLine());


            Console.Write("İkinci aldığı ürünün fiyatı: ");
            decimal ikinciUrunFiyati = Convert.ToDecimal(Console.ReadLine());


            // Toplam ne kadar harcadığını hesaplarken parasal değer olduğu için yine decimal veri tipini kullanıyorum.
            decimal toplamHarcama = ilkUrunFiyati + ikinciUrunFiyati;


            // Toplam harcama karşılığı yüzde kaç patika puanı kazandığını yüksek hassasiyetle hesaplanması için decimal veri tipi ile yazıyorum.
            decimal patikaPuani = toplamHarcama * 0.10m;

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine($"{tcKimlikNo} T.C. numarali {adi} isimli kisi icin kayit olusturulmustur.");
            Console.WriteLine($"{telefonNumarasi} telefon numarasina bildirim mesaji gonderilmistir.");
            Console.WriteLine($"{toplamHarcama} toplam harcama karsiligi kazanilan patika puanı miktari -> {patikaPuani} 'dir.");
        }
    }
}
