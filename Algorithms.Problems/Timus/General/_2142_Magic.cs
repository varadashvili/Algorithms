using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2142_Magic
    {
        public static void main()
        {
            var lands = Console.ReadLine().Trim().Split(' ');
            var manas = Console.ReadLine().Trim().Split(' ');

            var redLand = long.Parse(lands[0]);
            var blueLand = long.Parse(lands[1]);
            var universalLand = long.Parse(lands[2]);

            var redMana = long.Parse(manas[0]);
            var blueMana = long.Parse(manas[1]);
            var universalMana = long.Parse(manas[2]);

            long remainingRedMana = redLand - redMana;
            long remainingBlueMana = blueLand - blueMana;

            if (remainingRedMana < 0)
            {
                universalLand = universalLand + remainingRedMana;
                remainingRedMana = 0;
            }

            if (remainingBlueMana < 0)
            {
                universalLand = universalLand + remainingBlueMana;
                remainingBlueMana = 0;
            }

            long remainingUniversalMana = remainingRedMana + remainingBlueMana + universalLand - universalMana;


            if (remainingRedMana >= 0 && remainingBlueMana >= 0 && universalLand >= 0 && remainingUniversalMana >= 0)
            {
                Console.WriteLine("It is a kind of magic");
            }
            else
            {
                Console.WriteLine("There are no miracles in life");
            }

            Console.ReadLine();
        }
    }
}
