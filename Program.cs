#region string Metotları

// string ifade = "C# Eğitimi Kutay Öztürk";
// Console.WriteLine("------------Karakter Çevirme------------");
// string buyukHarfler = ifade.ToUpper();
// string kucukHarfler = ifade.ToLower(); // ToUpper fonskiyonu ile tüm harfleri büyük harfe dönüştürdük.

// // Not: ToUpper ve benzeri fonksiyonlar, değişkenin kendisini değiştirmezler. Bir kopyasını alırlar. Bu sebele:

// Console.WriteLine(ifade); // Değişkenin kendisi
// Console.WriteLine(buyukHarfler);
// Console.WriteLine(kucukHarfler);

// Console.WriteLine("------------String'den Alt Stringler üret------------");
// string sonuc1 = ifade.Substring(5);
// string sonuc2 = ifade.Substring(2, 7);
// Console.WriteLine(sonuc1);
// Console.WriteLine(sonuc2);

// Console.WriteLine("------------ile mi başlıyor------------");
// bool sonuc3 = ifade.StartsWith("A");
// bool sonuc4 = ifade.StartsWith("C"); // Büyük Küçük harfe Duyarlıdır.
// Console.WriteLine(sonuc3);
// Console.WriteLine(sonuc4);

// Console.WriteLine("------------Değiştir------------");
// string cumle = "Hava bugün çok güzel";

// string sonuc5 = cumle.Replace('a', 'x');
// string sonuc6 = cumle.Replace("Hava", "Gökyüzü");
// Console.WriteLine(sonuc5);
// Console.WriteLine(sonuc6);

// Console.WriteLine("----------Sil------------");
// string sonuc7 = cumle.Remove(2); // Baştan kaçıncı index'ten sonrasını sileceğini belirttirk.
// string sonuc8 = cumle.Remove(5, 3); // 5. index'ten sonra 3 harfi kaldır dedik.
// Console.WriteLine(sonuc7);
// Console.WriteLine(sonuc8);

// Console.WriteLine("----------Ekle------------");
// string sonuc9 = cumle.Insert(0, "Merhaba "); // Girilen index numarasından sonra ilgili ifadeyi ekler
// string sonuc10 = cumle.Insert(cumle.Length, " öyle değil mi?"); // 5. index'ten sonra 3 harfi kaldır dedik.
// Console.WriteLine(sonuc9);
// Console.WriteLine(sonuc10);

// Console.WriteLine("----------içeriyor mu? (index)------------");
// int sonuc11 = cumle.IndexOf('a'); // string yada char ifadeler kontrol ebilebilir. içeriyorsa 1 değeri döndürülür
// int sonuc12 = cumle.IndexOf('x'); // ilgili ifade bulunamıyorsa -1 değeri döndürülür. 
// int sonuc13 = cumle.IndexOf("güzel"); // Kaşıncı index'ten başladığını söyler.
// Console.WriteLine(sonuc11);
// Console.WriteLine(sonuc12);
// Console.WriteLine(sonuc13);

// // -1 değeri sayesinde kontrol mekanizmasını kullanalım
// if (sonuc12 == -1)
// {
//     Console.WriteLine("Deger bulunamadı");
// }

// Console.WriteLine("----------içeriyor mu? (bool)------------");
// bool sonuc14 = cumle.Contains("bugün"); // string yada char ifadeler kontrol ebilebilir. içeriyorsa true değeri döndürülür
// Console.WriteLine(sonuc14);

#endregion

#region Matematiksel Metotlar
// Math kütüphanesinin altında bulunan hazır metotlardan oluştur. 
Console.WriteLine("------------Karekök------------");
double sayi1 = Math.Sqrt(9); // Geritye double döner
Console.WriteLine(sayi1);

Console.WriteLine("------------Aşağıya Yuvarla------------");
double sayi2 = Math.Floor(16.7);
Console.WriteLine(sayi2);

Console.WriteLine("------------Yukarı Yuvarla------------");
double sayi3 = Math.Ceiling(16.7);
Console.WriteLine(sayi3);

Console.WriteLine("------------Yuvarla------------");
double sayi4 = Math.Round(16.7);
Console.WriteLine(sayi4);

Console.WriteLine("------------En Büyük------------");
double sayi5 = Math.Max(4, 9);
Console.WriteLine(sayi5);

Console.WriteLine("------------En Küçük------------");
double sayi6 = Math.Min(13, 2);
Console.WriteLine(sayi6);

Console.WriteLine("------------Kuvvet (üssü)-----------");
double sayi7 = Math.Pow(3, 2); // 3'ün Karesi
Console.WriteLine(sayi7);






#endregion