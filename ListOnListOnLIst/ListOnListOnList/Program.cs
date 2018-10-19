using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOnListOnList
{
    class Program
    {
        static string ADD()
        {
            Console.Write("Gimme a string to add: ");
            return Console.ReadLine();
        }

        static void SEARCH(List<string> list)
        {//i was a little unclear about what to search and return
            Console.Write("Enter word to search: ");
            string s = Console.ReadLine();
            var v = list.OrderBy(a => a).Where(b => b.Contains(s));
            if (v.Count() > 0)
                Console.WriteLine($"the string '{s}' exist in the word '{string.Join(" ", v)}' at index {list.IndexOf(string.Join(" ", v))}.");
            else
                Console.WriteLine("string doesn't exist.");

        }

        static List<string> SORT(List<string> list)
        {
            return list.OrderBy(a => a).ToList();
        }

        static void Main(string[] args)
        {
            string s = "";
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("1) Add\n2) Search\n3) Sort\n4) Print");
                Console.Write("Enter: ");
                s = Console.ReadLine();
                if (!int.TryParse(s, out int n))
                {
                    Console.WriteLine("Bad number");
                    continue;
                }
                if (n == 1)
                {
                    list.Add(ADD());
                }
                else if (n == 2)
                    SEARCH(list);
                else if (n == 3)
                    list = SORT(list);
                else if (n == 4)
                    Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
