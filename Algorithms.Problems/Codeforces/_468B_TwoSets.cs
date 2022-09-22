using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Codeforces
{
    class _468B_TwoSets
    {
        public static bool recurse(int x, int type, int step)
        {
            nums[x] = step;
            finished.Enqueue(x);
            bool a_x, b_x;

            a_x = nums.ContainsKey(a - x);
            b_x = nums.ContainsKey(b - x);

            if (type == 0)
            {
                if (!a_x || nums[a - x] == 1)
                    return false;

                if (nums[a - x] != 0 && nums[a - x] != step)
                    if (!recurse(a - x, type, step))
                        return false;

                if (b_x)
                {
                    if (nums[b - x] == 1)
                        return false;
                    else if (nums[b - x] != 0 && nums[b - x] != step)
                        if (!recurse(b - x, type, step))
                            return false;
                }
            }
            else
            {
                if (!b_x || nums[b - x] == 0)
                    return false;

                if (nums[b - x] != 1 && nums[b - x] != step)
                    if (!recurse(b - x, type, step))
                        return false;

                if (a_x)
                {
                    if (nums[a - x] == 0)
                        return false;
                    else if (nums[a - x] != 1 && nums[a - x] != step)
                        if (!recurse(a - x, type, step))
                            return false;
                }
            }

            return true;
        }

        public static void set(int type)
        {
            while (finished.Count > 0)
                nums[finished.Dequeue()] = type;
        }

        static Dictionary<int, int> nums = new Dictionary<int, int>();
        static Queue<int> finished;
        static string[] inp;
        static int n, a, b, x;
        public static void main()
        {
            inp = Console.ReadLine().Split(' ');
            n = int.Parse(inp[0]);
            a = int.Parse(inp[1]);
            b = int.Parse(inp[2]);

            inp = Console.ReadLine().Split(' ');

            for (int i = 0; i < inp.Length; i++)
            {
                x = int.Parse(inp[i]);
                nums[x] = -1;
            }

            bool res1 = true, res2 = true;
            for (int i = 0; i < inp.Length; i++)
            {
                x = int.Parse(inp[i]);
                if (nums[x] != 1 && nums[x] != 0)
                {
                    finished = new Queue<int>();
                    res1 = recurse(x, 0, 10 + 2 * i);
                    if (res1)
                    {
                        set(0);
                    }
                    else
                    {
                        finished = new Queue<int>();
                        res2 = recurse(x, 1, 11 + 2 * i);
                        if (res2)
                            set(1);
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("YES");
            for (int i = 0; i < inp.Length; i++)
            {
                Console.Write(nums[int.Parse(inp[i])] + " ");
            }
        }
    }
}
