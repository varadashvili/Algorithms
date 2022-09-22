using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1991_TheBattleNearTheSwamp
    {
        public static void main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int booms = 0, droids = 0;

            var input = Console.ReadLine().Trim().Split(' ');
            int blocks = int.Parse(input[0]);
            int cnt = int.Parse(input[1]);

            var blockinfo = Console.ReadLine().Trim().Split(' ');
            int cur = 0;

            for (int i = 0; i < blocks; i++)
            {
                cur = int.Parse(blockinfo[i]);

                if (cur > cnt)
                    booms += cur - cnt;
                else
                    droids += cnt - cur;
            }

            Console.WriteLine(booms + " " + droids);
        }
    }
}
