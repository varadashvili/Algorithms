using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2111_Plato
    {
        public static void main()
        {
            long cityCount = long.Parse(Console.ReadLine());

            long currntWeight = 0;

            long finalFee = 0;

            var weights = (Console.ReadLine()).Split(' ');

            for (int i = 0; i < cityCount; i++)
            {
                long newWeight = long.Parse(weights[i]);

                currntWeight = currntWeight + newWeight;

                finalFee = finalFee + (currntWeight * newWeight + newWeight * (currntWeight - newWeight));
            }

            Console.WriteLine(finalFee);

            Console.ReadLine();
        }
    }
}
