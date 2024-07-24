
int yas;
yas = 24; // assignment - set - atama işlemi.

Console.WriteLine(yas); // read - okuma işlemi.

char karakter = 'i'; // assignment          

string isim = "irem"; //assignment

// string aslında karakterlerden oluşan bir dizi.


Console.WriteLine("Lütfen adınızı yazınız");
isim = Console.ReadLine(); //assignment

Console.WriteLine("Değişken içerisindeki veri ---->" + isim); // read

Console.WriteLine("-----------");

Console.WriteLine("Lütfen yaşınızı giriniz.");
int yas2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kişinin yaşı -> " + yas2);