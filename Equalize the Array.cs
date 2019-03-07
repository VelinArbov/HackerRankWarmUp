using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equalize_the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int numbers = int.Parse(Console.ReadLine());

            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
            int commons = elements.GroupBy(c => c).Max(group => group.Count());
            Console.WriteLine(elements.Count-commons);
            }
        }
    }

