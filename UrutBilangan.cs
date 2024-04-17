// 6. Mengurutkan bilangan bulat dari terkecil ke terbesar
using System;

class UrutBilangan
{
    static void Main()
    {
        Console.Write("Masukkan jumlah bilangan: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] bilangan = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Masukkan bilangan ke-{i + 1}: ");
            bilangan[i] = Convert.ToInt32(Console.ReadLine());
        }
       
        Array.Sort(bilangan);

        Console.WriteLine("Bilangan terurut:");
        foreach (int num in bilangan)
        {
            Console.Write(num + " ");
        }
    }
}