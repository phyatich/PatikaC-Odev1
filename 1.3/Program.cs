using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} adet kelime giriniz: ");
            string[] wordList = new string[n];
            for (int i = 0; i < n; i++)
            {
                wordList[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(wordList[i]);
            }
        }
    }
}
