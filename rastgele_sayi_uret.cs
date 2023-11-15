// Rastgele Sayı Üretmek
Random rnd = new Random(); // Random fonksiyonu ile rnd adında bir nesne oluşturduk
int rastgele = rnd.Next(); // rnd ile oluşturulan bu nesneden elde edilecek değeri, rastgele isimli değişkene atadık.
Console.WriteLine(rastgele);

Console.WriteLine("-------MAX DEĞER-------");
int rastgele1 = rnd.Next(15); // Tek bir parametre girilirse Max Value (pozitif değerler üretir. 0 ile 15 arasında ama 15 dahil DEĞİLDİR.)
Console.WriteLine(rastgele1);

Console.WriteLine("-------MAX - MİN DEĞER ARASI-------");
int rastgele2 = rnd.Next(15,42); // MAx ve Min değerler girilebilir. Min değer DAHİLDİR, MAx değer Dahil DEĞİLDİR.
Console.WriteLine(rastgele2);

Console.WriteLine("-------Ondalıklı-------");
double rastgele3 = rnd.NextDouble(); // NextDouble ile üretilen değerler, 0 ile 1 arasında ondalıklı sayılardır.
Console.WriteLine(rastgele3);