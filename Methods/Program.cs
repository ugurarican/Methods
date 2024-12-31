// Void metod tanımlama
void SarkiSozu()
{
    Console.WriteLine("Not to ride along with you");
}
int Kalan()
{
    //Random classını çağırıyoruz.
    Random random = new Random();

    // Üretilen random nesnesine alt ve üst sınır verip 1 tane sayı oluşturuyoruz.
    int sayi = random.Next(1,100);

    //2 ile kalanını buluyoruz.
    int kalan = sayi % 2;
    return kalan;
}
// Parametre olarak 2 tane sayı alıp bunları çarpıp sonucunu dönen metot.
//Burada ekrana yazdırma komutlarını metot dışında tuttum.
int Carpma(int sayi1, int sayi2) { 
        return sayi1*sayi2;
}

//Parametre olarak isim soyisiim alıp Hoş geldiniz {isim} {soyisim} yazan metot.
string HosGeldiniz(string ad, string soyad)
{
    return ad+ soyad;
}


// En sevdiğim şarkı sözü metodunu çağırıyoruz.
SarkiSozu();

// Rastgele 1-100 arasında üretilen sayının 2 ile bölümünden akalan sayıyı dönen metot.
Kalan();

// Ekrana girilen 1. ve 2. sayıyı parametre olarak alıp bunu çarpıp sonuç dönen metot.
Console.WriteLine("Lütfen çarpmak istediğiniz 1. sayıyı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen çarpmak istediğiniz 2. sayıyı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = Carpma(sayi1,sayi2);
Console.WriteLine($"Çarpma işleminin sonucu : {sonuc}");

Console.WriteLine("Lütfen adınızı girin: ");
string ad = Console.ReadLine();

Console.WriteLine("Lütfen soyadınızı girin: ");
string soyad = Console.ReadLine();

HosGeldiniz(ad, soyad);
Console.WriteLine($"Hoş geldiniz {ad} {soyad}");