using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.WorkingProblems
{
    class _1115_Ships
    {
        public static void main()
        {
            var input = Console.ReadLine().Split(' ');
            short shipCount = short.Parse(input[0]);
            short rowCount = short.Parse(input[1]);

            List<Ship> ships = new List<Ship>();
            List<Row> rows = new List<Row>();

            for (short i = 1; i <= shipCount; i++)
            {
                var ln = short.Parse(Console.ReadLine());
                ships.Add(new Ship { Length = ln});
            }

            for (short i = 1; i <= rowCount; i++)
            {
                var ln = short.Parse(Console.ReadLine());
                rows.Add(new Row { Length = ln, FreeLength = ln, initalPos = i });
            }

            ships = ships.OrderByDescending(o => o.Length).ToList();
            rows = rows.OrderBy(o => o.Length).ToList();

            foreach (var row in rows)
            {
                foreach (var ship in ships)
                {
                    if (!ship.isUsed && ship.Length <= row.FreeLength)
                    {
                        ship.isUsed = true;

                        row.ships.Add(ship);
                        row.FreeLength -= ship.Length;
                        row.isFull = row.FreeLength == 0;
                    }

                    if (row.isFull)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        class Ship
        {
            public short Length { get; set; }

            public bool isUsed { get; set; } = false;
        }

        class Row
        {
            public short Length { get; set; }

            public short FreeLength { get; set; }

            public bool isFull { get; set; } = false;

            public short initalPos { get; set; }

            public List<Ship> ships { get; set; } = new List<Ship>();
        }
    }
}
