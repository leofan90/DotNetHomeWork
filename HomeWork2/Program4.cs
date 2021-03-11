using System;

namespace HomeWork2
{
    class Program4
    {
        private static void Toeplitz(int row, int column, int[,] x)
        {
            int m = row;
            int n = column;
            int[,] a = x;
            for (int i = 0; i+1 < m; i++)
            {
                int count = 0;
                for (int j = 0; j+1 < n; j++)
                {
                    if (a[i, j] == a[i+1, j+1])
                    {
                        count++;
                    }
                }
                if (count != n - 1)
                {
                    Console.WriteLine(false);
                    return;
                }
            }
            Console.WriteLine(true);
        }
        static void Main(string[] args)
        {
            string s = "";
            int row;
            int column;
            Console.WriteLine("please enter the number of row:");
            s = Console.ReadLine();
            row = Int32.Parse(s);
            Console.WriteLine("please enter the number of column:");
            s = Console.ReadLine();
            column = Int32.Parse(s);
            int[,] x = new int[row, column]; 
            Console.WriteLine("请输入二维数组的值：");
            for (int i = 0; i < row; i++)
            {
                string str = Console.ReadLine();
                string[] tmp = str.Split(" ".ToCharArray());
                for (int j = 0; j < column; j++)
                {
                    x[i, j] = Int32.Parse(tmp[j]);
                }
            }
            Toeplitz(row, column, x);
        }
    }
}
