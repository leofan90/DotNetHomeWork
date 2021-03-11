using System;

namespace HomeWork2
{
    class Program1
    {
        private static void JudgeCanDivided(int x)
        {
            int a = x;
            int b = 2;
            int count = 0;
            int[] c;
            c = new int[5];
            while(a > 1)
            {
                if(a % b == 0)
                {
                    a = a / b;
                    c[count] = b;
                    count++;
                }
                else
                    b++;
            }
            foreach (int num in c)
            {
                if(num != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
        static void Main(string[] args)
        {
            string s = "";
            int num;
            Console.WriteLine("please enter a number:");
            s = Console.ReadLine();
            num = Int32.Parse(s);
            JudgeCanDivided(num);

        }
    }
}
