using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1510_Order
    {
        //Boyer–Moore majority vote algorithm
        public static void main()
        {
            int banknote = 0;
            int counter = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int newBanknote = int.Parse(Console.ReadLine());

                //for memory limit
                if (i % 10000 == 0)
                {
                    GC.Collect();
                }

                if (counter == 0)
                {
                    banknote = newBanknote;
                    counter++;
                }
                else if (banknote == newBanknote)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }


            Console.WriteLine(banknote);

            Console.ReadLine();
        }
    }
}
