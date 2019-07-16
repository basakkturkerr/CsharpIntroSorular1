using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntroSorular1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1)	“10200” sayısını int e çevirip ekrana yaz.

            //String sayi = "10200";
            //int sayi2 = Convert.ToInt32(sayi);

            //Console.WriteLine(sayi2);
            //Console.ReadLine();


            // 2)	“12.5” sayısını double a çevir ve ekrana yaz.

            //String sayi = "12.5";
            //Double sayi2 = Convert.ToDouble(sayi);

            //Console.WriteLine(sayi2);
            //Console.ReadLine();


            // 3)	Ekrandan girilen sayıyı 1.18 le çarpıp ekrana yaz.

            //Console.WriteLine("Bir sayi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi * 1.18);
            //Console.ReadLine();


            // 4)	Ekrandan girilen iki sayıyı toplayıp ekrana yaz.

            //Console.WriteLine("Birinci sayiyi giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayiyi giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi1 + sayi2);
            //Console.ReadLine();

            // 5)	Ekrandan girilen sayı 100 den büyükse ekrana “PAHALI ” yazdır.

            //Console.WriteLine("Bir sayi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 100)
            //{
            //    Console.WriteLine("PAHALI");
            //}

            //Console.ReadLine();

            // 6)	Ekranan girilen sayıya göre günü yazdır. (1 ise pazartesi, 2 ise Salı vb.).

            //Console.WriteLine("Bir sayi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi == 1)
            //{
            //    Console.WriteLine("PAZARTESİ");
            //}

            //else if (sayi == 2)
            //{
            //    Console.WriteLine("SALI");
            //}

            //else if (sayi == 3)
            //{
            //    Console.WriteLine("ÇARŞAMBA");
            //}

            //else if (sayi == 4)
            //{
            //    Console.WriteLine("PERŞEMBE");
            //}

            //else if (sayi == 5)
            //{
            //    Console.WriteLine("CUMA");
            //}

            //else if (sayi == 6)
            //{
            //    Console.WriteLine("CUMARTESİ");
            //}

            //else if (sayi == 7)
            //{
            //    Console.WriteLine("PAZAR");
            //}

            //Console.ReadLine();


            // 7)	Klavyeden öğrencinin 2 adet not bilgisi girildikten sonra, ortalama 50 ve üzerinde ise ekrana “Geçti” değilse “Kaldı” yazdır.

            //Console.WriteLine("İlk notu giriniz");
            //Double not1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İkinci notu giriniz");
            //Double not2 = Convert.ToDouble(Console.ReadLine());

            //Double ortalama = ((not1 + not2) / 2);

            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("GEÇTİ");
            //}

            //else
            //{
            //    Console.WriteLine("KALDI");
            //}

            //Console.ReadLine();


            // 8)	Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz kullanıcı adı veya şifre hatalı” yazdır.

            //string sifre = "basak123";
            //string kullanici = "basak";

            //Console.WriteLine("Kullanici adi giriniz: ");
            //string kul = Console.ReadLine();

            //Console.WriteLine("Sifre giriniz : ");
            //string sif = Console.ReadLine();

            //if(sif.Equals(sifre) && kul.Equals(kullanici))
            //{
            //    Console.WriteLine("Giris basarili");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı.");
            //}

            //Console.ReadLine();


            // 9)	Girilen sayının negatif, pozitif veya sıfır olduğunu ekranda belirt.

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi < 0)
            //{
            //    Console.WriteLine("NEGATİF");
            //}

            //else if (sayi > 0)
            //{
            //    Console.WriteLine("POZİTİF");
            //}

            //else
            //{
            //    Console.WriteLine("SIFIR");
            //}

            //Console.ReadLine();


            // 10)	Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı göster.

            //Console.WriteLine("İlk ürünün fiyatını giriniz");
            //Double urun1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İkinci ürünün fiyatını giriniz");
            //Double urun2 = Convert.ToDouble(Console.ReadLine());

            //Double toplam = urun1 + urun2;

            //if (toplam > 200)
            //{
            //    Double indirim = (urun2 - (urun2 * 25 / 100));
            //    Console.WriteLine(indirim + urun1);
            //}

            //else
            //{
            //    Console.WriteLine(toplam);
            //}

            //Console.ReadLine();

            // 11)	Girilen 3 sayıdan en az biri 50’den büyükse “Yeterli”, aksi halde “Yetersiz” mesajı veren program.

            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Üçüncü sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > 50 || sayi2 > 50 || sayi3 > 50)
            //{
            //    Console.WriteLine("Yeterli");
            //}

            //else
            //{
            //    Console.WriteLine("Yetersiz");
            //}

            //Console.ReadLine();


            // 12)	Girilen 3 sayının hepsi 0’dan büyük ve çift ise “Başarılı Giriş”, aksi halde “Başarısız giriş” mesajı veren program.

            //Console.WriteLine("Birinci sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Üçüncü sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > 0 && sayi1 % 2 == 0 && sayi2 > 0 && sayi2 % 2 == 0 && sayi3 > 0 && sayi3 % 2 == 0)
            //{
            //    Console.WriteLine("Yeterli");
            //}

            //else
            //{
            //    Console.WriteLine("Yetersiz");
            //}

            //Console.ReadLine();

            // 13)	Girilen iki sayıyı karşılaştıran ve büyük, küçük ya da eşit olma durumunu gösteren program. Örneğin “2. Girdiğiniz sayı 1. den büyük” gibi.

            // Console.WriteLine("Birinci sayıyı giriniz");
            // int sayi1 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("İkinci sayıyı giriniz");
            // int sayi2 = Convert.ToInt32(Console.ReadLine());

            // if (sayi1 > sayi2 )
            // {
            //     Console.WriteLine("1. Girdiğiniz sayı 2.den büyük");
            // }

            //else if (sayi1 < sayi2)
            // {
            //     Console.WriteLine("2. Girdiğiniz sayı 1.den büyük");
            // }

            // else
            // {
            //     Console.WriteLine("Girilen iki sayı birbirine eşit");
            // }

            // Console.ReadLine();

            // 14)	Dışarıdan girilen bir N sayısına kadar olan sayıların toplamını bulan program.

            //int t = 0;

            //Console.WriteLine("N değerini gir");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= n; i++)
            //    t = t + i;

            //Console.WriteLine("1 den N e kadar olan sayıların toplamı = " + t);
            //Console.ReadLine();

            // 15)	Aşağıdaki formu ekrana yazdıran program. 
            //         *
            //      *  *  *
            //   *  *  *  *  * 
            //*  *  *  *  *  *  *
            //int sayi = 8;
            //for (int i = 1; i < sayi; i++)
            //{
            //    if(i % 2 == 1)
            //    {
            //        for (int j = i; j < sayi; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k <= i; k++)
            //        {
            //            Console.Write("*");
            //            Console.Write(" ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //Console.ReadLine();

            // 16)	Aşağıdaki formu ekrana yazdıran program.
            //  1
            //  2   3
            //  4   5   6
            //  7   8   9   10
            //  11  12  13  14

            int sayi = 6;
            int k = 0;
            for (int i = 1; i < sayi; i++)
            {
                for (int j = k; j < i + k; j++)
                {
                    Console.Write(1 + j);
                    Console.Write(" ");
                }
                k = k + i;

                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
