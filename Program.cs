using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersofsocks = int.Parse(Console.ReadLine());

            List<string> socks = Console.ReadLine().Split().ToList();
            socks.Sort();
            List<string> sorted = new List<string>();
            int sortedCount = 0;
            for (int i = 0; i <socks.Count-1; i++)
            {
                string currentSock = socks[i];
                if ( currentSock == socks[i+1])
                {
                    socks.Remove(currentSock);
                    socks.Remove(currentSock);
                    sortedCount++;
                    i = -1;
                }



               

            }
            Console.WriteLine(sortedCount);
        }
    }
}
