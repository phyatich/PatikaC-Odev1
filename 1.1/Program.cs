using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} adet pozitif sayı giriniz: ");
            int[] numList = new int[n];
            for (int i = 0; i < n; i++)
            {
                numList[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (numList[i] % 2 == 0)
                {
                    Console.Write(numList[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
