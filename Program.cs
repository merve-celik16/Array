using System;
using System.Linq;

int[] sayilar = new int[10] { 2, 4, 5, 7, 8, 9, 11, 44, 50, 12 }; // 10 elemanlı bir tam sayı dizisi oluşturduk

// For döngüsü ile diziyi doldurma
for (int i = 0; i < sayilar.Length; i++)
{

}
// Foreach döngüsü ile diziyi ekrana yazdırma
Console.WriteLine("Dizi elemanları:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Console.Write("Yeni bir sayı giriniz: ");
int yeniSayi = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref sayilar, sayilar.Length + 1);//Diziyi yeniden boyutlandırıyoruz
sayilar[sayilar.Length - 1] = yeniSayi;

// 4. Adım: Sıralama ve yazdırma
Array.Sort(sayilar); //Küçükten büyüye sıralayıp
Array.Reverse(sayilar); // Küçükten büyüye sıralamış olduğum diziy ters çevirdim

Console.WriteLine("Büyükten küçüğe sıralanmış dizi:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
