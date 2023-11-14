using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  *** string Birleştirme (string interpolation)
				
					Console.Write("Adınızı giriniz: ");
					string ad = Console.ReadLine();
					Console.Write("Soyadınızı giriniz: ");
					string soyad = Console.ReadLine();
					Console.Title= $"{ad} {soyad}";
					// $ işareti ile birleşemesini istediğimiz string ifadeleri birleştirdik.
					// string ifadeler + operatörü ile de birlşetirilebilir ancak, $ işareti yöntemi çok daha optimize çalışmaktadır.
					// Bu yönteme string interpolation denir.
				
			#endregion
			
            #region *** Basit Örnek
				//Console.Write("1. sayıyı giriniz: ");
				//int sayi1 = Convert.ToInt32(Console.ReadLine());
				
				//Console.Write("2. sayıyı giriniz: ");
				//int sayi2 = Convert.ToInt32(Console.ReadLine());
				
				//// int toplam;
				//// Console.WriteLine(sayi1 + sayi2);
				//Console.WriteLine($"{sayi1} ile {sayi2}'nin toplamı = {sayi1 + sayi2} eder");
			#endregion
			
            #region *** SORU - 001
				//Bir bankanin kredi verme bölümünde kullanilacak bir uygulama gelistirmeniz isteniyor.Bu uygulamada ekrandan;
				
				//*müsterinin çekmek istedigi kredi tutari girilecek
				
				//* müsterinin bu krediyi kaç ayda geri ödemek istedigi bilgisi girilecek
				
				//* krediye uygulanacak faiz oran1 girilecek
				
				//Bu degerler girildikten sonra ekranda müsterinin;
				
				//*Geri ödeyeceği toplam tutar
				
				//* Aylik ödeme tutuari
				
				//*Geri ödeyecei faiz tutari
			#endregion
			
            #region *** Cevap - 001
				
				
				//Console.WriteLine("Çekmek istediğiniz Kredi miktarını giriniz: ");
				//int krediTutari = Convert.ToInt32(Console.ReadLine());
				
				//Console.WriteLine("Kredinizi kaç taksit ile ödemek istersiniz: ");
				//int vadeSayisi = Convert.ToInt32(Console.ReadLine());
				
				//Console.WriteLine("Kredi faiz oranını giriniz: ");
				//double faizOrani = double.Parse(Console.ReadLine());
				
				//double toplamOdenecekTutar = ((krediTutari * faizOrani) / vadeSayisi) * 12;
	
				//Console.WriteLine($"Geri Ödenecek Toplam Tutar: {toplamOdenecekTutar}");
				//Console.WriteLine($"Aylık Taksit Tutarı: {toplamOdenecekTutar / vadeSayisi}");
				//Console.WriteLine($"Ödenecek Toplam Faiz: {toplamOdenecekTutar - krediTutari}");
				
			#endregion
			
			
            Console.ReadKey();
		}
	}
}
