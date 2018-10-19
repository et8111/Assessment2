using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut
{
    class Program
    {
        static int loader()
        {
            int n = 0;
            Console.Write("Pick a number > 0: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 1)       //check for integer only
            {
                Console.WriteLine("numbers > 0 only.");
                n = loader();
            }
            return n;
        }

        static void Main(string[] args)
        {
            int num = loader();
            int odds = 1;
            int[] ar = new int[num/2];
            for (int i = 0; i < num / 2; i++)  //skip evens only count odds, cut loop time in half
            {
                ar[i] = odds;
                odds += 2;
            }

            int count = ar.Length;
            int sum = ar.Sum();
            Console.WriteLine($"The sum of all odd number is {sum}, the average is {sum/count}.");
        }
    }
}
