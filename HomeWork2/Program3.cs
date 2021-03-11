using System;

namespace HomeWork2
{
    class Program3
    {
        private static void Eratosthenes(int[] x)
        {
            int[] a = x;
            for (int i = 2; i < a.Length; i++)
            {
                int j = 2 * i;
                for (; j < a.Length && a[j] % i == 0; j += i)
                {
                    a[j] = 0;
                }
            }
            foreach (int num in a)
            {
                if(num != 0 && num != 1)
                {
                    Console.WriteLine(num);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[101];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
            }
            Eratosthenes(a);
        }
    }
}
