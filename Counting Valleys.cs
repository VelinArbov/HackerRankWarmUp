using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankwarmUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string valey = Console.ReadLine();
            int level = 0;
            int valeys = 0;
            for (int i = 0; i < number; i++)
            {
                char currentSymbol = valey[i];

                if(currentSymbol == 'D')
                {
                    level--;
                }
                else
                {
                    level++;
                }
                if ( level== 0 && currentSymbol =='U')
                {
                    valeys++;
                }

            }
           
            Console.WriteLine(valeys);


        }
    }
}
