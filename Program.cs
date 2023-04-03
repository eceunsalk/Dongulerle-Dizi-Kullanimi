internal class Program
{
    private static void Main(string[] args)
    {
        //Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar ={"Kedi","Köpek","Kuş","Maymun"}; //elemanlarını biliyorsak direkt atamasını yaparak string belirleyebiliriz. Bu dizinin boyutu 4.
        int[] dizi;
        dizi = new int[5]; //Tanımlarken bunun boyutunu ve elemanlarını vermek zorunda değilim. kullanacağım zaman belirtebilirim.

        //Dizilere Değer Atama ve Erişim
        renkler[0] = "Mavi";
        Console.WriteLine(hayvanlar[0]); //Hayvanlar dizisindeki ilk elemanı bana getirir. 
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngülerle Dizi Kullanımı
        // Klavyeden girilen n tane sayının ortalamasını hesaplayan program. Bir dizi oluşturacağım, dizinin boyutuna konsoldan gelen veri karar versin. N sayısına da konsoldan gelen veri karar versin, bu verileri de konsoldan alayım. Son olarak, bu diziye atamış olduğum değerlerin ortalamasını alayım. 

        Console.Write("Lütfen dizinin elaman sayısını giriniz: "); 
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu]; //konsoldan girilen sayıya göre bellekten bir dizi aldım. 
        // bu dizinin elemanlarını konsoldan almamız gerekiyor.

        for (int i = 0; i < diziUzunlugu; i++) // benim dizilerimin indeksleri 0'dan başlıyor. küçük olacak küçük eşit değil zaten 5 elemanlı dizi için maks. 4 indeksim old. biliyorum.
        {
            Console.Write("Lütfen {0}.sayıyı giriniz: ", i+1); // i+1 dememin sebebi kullanıcıya 0.sayıyı girin demek istemiyorum, kullanıcı için 0.eleman 1.elemandır.
            //kullanıcıdan aldığımız değeri dizimize atıyor olmamız gerekiyor.
            sayiDizisi[i] = int.Parse(Console.ReadLine()); //bunun i.indeksine ekrandan konsoldan aldığın değeri yaz. bir dizi tanımladık. o dizinin elemanlarına atama yaptık. 
        }
        int toplam = 0; // her bir elemanı tek tek toplayacağız. dolayısıyla hepsini toplayacağımız değişkene ihtiyacımız var. başlangıçta 0 değerini veriyoruz.
        foreach (var sayi in sayiDizisi) // yukarıda oluşturmuş olduğumuz dizinin elemanları içinde döneceğiz. foreach dizilerde collection tiplerinde dönmemi sağlayan döngü olduğu için for değil foreach kullanıyoruz. hazır diziyle çalışıyorken neden foreach kullanmayalım. 
            toplam += sayi; //
        Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
        



    }
}