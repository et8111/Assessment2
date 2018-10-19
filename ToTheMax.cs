using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax
{
    class Program
    {
        static int loader(string msg, bool foo)
        {
            Console.Write(msg);
            if (!int.TryParse(Console.ReadLine(), out int n))       //check for integer only
            {
                Console.WriteLine("Integers only.");
                n = loader(msg, foo);
            }
            if (n <= 0 && foo)
            {
                Console.WriteLine("Positive Integer for length.");  //for initializing array make sure its possitive
                n = loader(msg, foo);
            }
            return n;
        }

        static void Main(string[] args)
        {
            int num = 0;
            num = loader("Ener an array length (greater then 0): ", true);
            int[] ar = new int[num];
            for (int i = 0; i < num; i++)
                ar[i] = loader($"Enter Index {i+1}: ", false);
            int max = ar[0];                                        //Initiate to index 0 in case all nubmers are negative
            foreach (var v in ar)
                max = (v > max) ? v : max;
            Console.WriteLine($"\nMax number is {max}.");
        }
    }
}
