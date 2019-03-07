using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmaJump
{
    class EmmaJumps
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            List<int> clouds = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;
            int i = 0;
            while (i < clouds.Count - 1)
            {
                if (i + 2 < clouds.Count && clouds[i + 2] != 1)
                {
                    count++;
                    i = i + 2;
                }
                else
                {
                    count++;
                    i++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
