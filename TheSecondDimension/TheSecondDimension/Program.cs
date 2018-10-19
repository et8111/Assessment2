using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondDimension
{
    class Program
    {
        static int SUM(int[,] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.GetLength(0); i++)
                for (int j = 0; j < ar.GetLength(1); j++)
                    if (i == j)
                        sum += ar[i, j];
            //for (int i = 0; i < ar.GetLength(0); i++)
            //    sum += ar[i, i];
            return sum;
        }

        static void Main(string[] args)
        {
            int[,] ar = new int[4, 4] { { 5, -4, 3, 0 }, { 5, 1, -2, -1 }, { 8, 6, -7, 4 }, { -2, 1, -5, 2 } };
            int sum = SUM(ar);
            Console.WriteLine($"SUM = {sum}");
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                    Console.Write($"{ar[i, j], 2} ");
                Console.WriteLine();
            }
        }
    }
}
