using System;

namespace HomeWork2
{
    class Program2
    {
        private static void Maxium(int[] x)
        {
            int[] a = x;
            int f = a[0];
            foreach (int num in a)
            {
                if (num > f)
                {
                    f = num;
                }
            }
            Console.WriteLine(f);
        }

        private static void Minium(int[] x)
        {
            int[] a = x;
            int f = a[0];
            foreach (int num in a)
            {
                if (num < f)
                {
                    f = num;
                }
            }
            Console.WriteLine(f);
        }

        private static void Sum(int[] x)
        {
            int[] a = x;
            int sum = 0;
            foreach (int num in a)
            {
                sum+=num;
            }
            Console.WriteLine(sum);
        }

        private static void Mean(int[] x)
        {
            int[] a = x;
            int sum = 0;
            foreach (int num in a)
            {
                sum+=num;
            }
            Console.WriteLine(sum / a.Length);
        }
        static void Main(string[] args)
        {
            int[] a = {3,6,7};
            Maxium(a);
            Minium(a);
            Mean(a);
            Sum(a);
        }
    }
}
