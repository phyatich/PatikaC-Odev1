using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string word = Console.ReadLine();
            string[] wordArray = word.Split(' ');
            int numberOfWords = wordArray.Length;
            int numberOfLetters = 0;
            foreach(var item in wordArray)
            {
                numberOfLetters += item.Length;
            }
            Console.WriteLine($"Toplam kelime sayısı: {numberOfWords}");
            Console.WriteLine($"Toplam harf sayısı: {numberOfLetters}");
        }
    }
}
