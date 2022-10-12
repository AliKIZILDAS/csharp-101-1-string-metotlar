using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2="Dersimiz CSharp";
            
            Console.WriteLine(degisken.Length); // karakter sayısını verir.
            Console.WriteLine(degisken.ToUpper()); // Hepsini büyütür.
            Console.WriteLine(degisken.ToLower()); // Hepsini küçültür.
            Console.WriteLine(string.Concat(degisken, " Merhaba")); // iki kelimeyi birleştirir.
            Console.WriteLine(degisken.CompareTo(degisken2)); // iki değişken karakter sayısı eşitse 0, büyüse1, küçükse -1
            Console.WriteLine(string.Compare(degisken,degisken2,true)); // büyük küçük harf duyarsız
            Console.WriteLine(string.Compare(degisken,degisken2,false)); // büyük küçük harf duyarlı
            Console.WriteLine(degisken.Contains(degisken2)); // büyük küçük harf duyarlı. değişken içinde değişke2 var ise true döner
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // kelimenin hoşgeldiniz ile bittiğini kontrol eder.
            Console.WriteLine(degisken.StartsWith("Merhaba!")); // kelimenin Merhaba ile başladığını kontrol eder.
            Console.WriteLine(degisken.IndexOf("CS")); // kelimenin bulunduğu indexi döner
            Console.WriteLine(degisken.IndexOf("Ali")); // kelimenin bulunduğu indexi döner
            Console.WriteLine(degisken.LastIndexOf("i")); // kelimenin bulunduğu indexi döner
            Console.WriteLine(degisken.Insert(0,"Merhaba ")); // kelimenin bulunduğu indexi döner
            Console.WriteLine(degisken+degisken2.PadLeft(30)); // kelimeyi 30 karakter yapar
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); // kelimeyi 30 karakter yapar
            Console.WriteLine(degisken+degisken2.PadRight(30)); // kelimeyi 30 karakter yapar
            Console.WriteLine(degisken+degisken2.PadRight(30,'*')); // kelimeyi 30 karakter yapar
            Console.WriteLine(degisken.Remove(10)); // ilk 10 karakteri getirir
            Console.WriteLine(degisken.Remove(5,3)); // beşinci dahil sonraki üç karakter
            Console.WriteLine(degisken.Remove(0,3)); // ilk üç karakteri siler
            Console.WriteLine(degisken.Replace("Csharp", "C#")); //değiştirir.
            Console.WriteLine(degisken.Replace(" ", "#")); //değiştirir.
            Console.WriteLine(degisken.Split(' ')[1]); //1. index kelimeyi getirir.
            Console.WriteLine(degisken.Substring(4)); //4. indexden başlayarak getirir.
            Console.WriteLine(degisken.Substring(4,6)); //4. indexden başlayarak 6 karakter getirir.           
        }


    }
}
