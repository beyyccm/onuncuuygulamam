using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan isim ve soyisim bilgisi alınır
        Console.Write("İsminizi giriniz: ");
        string isim = Console.ReadLine();

        Console.Write("Soyisminizi giriniz: ");
        string soyisim = Console.ReadLine();

        // 4. metot: Parametre alan ve geriye değer döndürmeyen metot çağrısı
        KarsilamaMesaji(isim, soyisim);

        Console.WriteLine("\n-----------------------------\n");

        // 1. metot: Geriye değer döndürmeyen metot çağrısı
        SarkiSozuYazdir();

        Console.WriteLine("\n-----------------------------\n");

        // 2. metot: Geriye tamsayı döndüren metot çağrısı
        int kalan = RastgeleSayiKalan();
        Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + kalan);

        Console.WriteLine("\n-----------------------------\n");

        // Kullanıcıdan iki sayı alınır
        Console.Write("1. sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // 3. metot: Parametre alan ve değer döndüren metot çağrısı
        int carpimSonuc = CarpimHesapla(sayi1, sayi2);
        Console.WriteLine($"{sayi1} ile {sayi2}'nin çarpımı: {carpimSonuc}");
    }

    // 1. metot: Geriye değer döndürmeyen void metot
    // Ekrana sevilen bir şarkı sözünü yazdırır
    static void SarkiSozuYazdir()
    {
        Console.WriteLine("üstüm başım alt üst olmuşum.");
       
    }

    // 2. metot: Geriye int döndüren metot
    // Rastgele sayı üretir ve bu sayının 2'ye bölümünden kalanı döndürür
    static int RastgeleSayiKalan()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 101); // 1 ile 100 arasında sayı üret
        Console.WriteLine("Oluşturulan rastgele sayı: " + sayi);
        return sayi % 2;
    }

    // 3. metot: Parametre alan ve değer döndüren metot
    // İki sayının çarpımını hesaplayıp döndürür
    static int CarpimHesapla(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    // 4. metot: Parametre alan ve değer döndürmeyen metot
    // Kullanıcının ismini ve soyismini alarak hoş geldiniz mesajı yazdırır
    static void KarsilamaMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"\nHoş Geldiniz {isim} {soyisim}!");
    }
}
