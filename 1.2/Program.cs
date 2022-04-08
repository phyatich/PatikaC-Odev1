using System;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pozitif bir sayı daha giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} adet pozitif sayı giriniz:");
            int[] numberList = new int[n];
            for (int i = 0; i < n; i++)
            {
                numberList[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (numberList[i] % m == 0)
                {
                    Console.Write(numberList[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
