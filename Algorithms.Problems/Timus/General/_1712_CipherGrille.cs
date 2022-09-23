using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _1712_CipherGrille
    {
        static string password = string.Empty;

        static List<int[]> cuts = new List<int[]>();
        static char[][] symbols = new char[4][];
        static comparer cmp = new comparer();

        public static void main()
        {
            for (int i = 0; i <= 3; i++)
            {
                var line = Console.ReadLine().ToCharArray();

                for (int j = 0; j <= 3; j++)
                {
                    if (line[j] == 'X')
                    {
                        cuts.Add(new int[2] { i, j });
                    }
                }
            }

            for (int i = 0; i <= 3; i++)
            {
                var line = Console.ReadLine().ToCharArray();

                symbols[i] = line;
            }


            readPassword();

            updateCuts();

            readPassword();

            updateCuts();

            readPassword();

            updateCuts();

            readPassword();

            Console.WriteLine(password);

        }

        static void readPassword()
        {
            cuts.ForEach(c => password += symbols[c[0]][c[1]]);
        }

        static void rotateMatrix()
        {
            char[][] newSymbols = new char[4][];

            for (int i = 0; i < 4; i++)
            {
                newSymbols[i] = new char[4];
                for (int j = 0; j < 4; j++)
                {
                    newSymbols[i][j] = symbols[j][3 - i];
                }
            }

            symbols = newSymbols;

        }

        static void updateCuts()
        {
            int t = 0;

            cuts.ForEach(c => { t = c[0]; c[0] = c[1]; c[1] = 3 - t; });

            cuts.Sort(cmp);
        }


    }

    public class comparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x[0] > y[0])
            {
                return 1;
            }
            else if (x[0] == y[0] && x[1] > y[1])
            {
                return 1;
            }
            else
            {
                return -1;
            }


        }
    }
}
