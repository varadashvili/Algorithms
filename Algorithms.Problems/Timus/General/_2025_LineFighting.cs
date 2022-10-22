using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2025_LineFighting
    {
        public static void main()
        {
            int testCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= testCount; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var players = int.Parse(input[0]);

                var teams = int.Parse(input[1]);

                var alfaTeamCount = players % teams;

                var betaTeamCount = teams - alfaTeamCount;

                var betaTeamPlayers = (players - alfaTeamCount) / teams;

                var alfaTeamPlayers = betaTeamPlayers + 1;

                var totalMatches =
                    alfaTeamPlayers * alfaTeamPlayers * alfaTeamCount * (alfaTeamCount - 1) / 2 +
                    alfaTeamCount * betaTeamCount * alfaTeamPlayers * betaTeamPlayers +
                    betaTeamPlayers * betaTeamPlayers * betaTeamCount * (betaTeamCount - 1) / 2;

                Console.WriteLine(totalMatches);
            }

            Console.ReadLine();
        }
    }
}
