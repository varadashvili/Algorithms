using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Timus.General
{
    class _2002_TestTask
    {
        public static void main()
        {
            //SortedDictionary<string, string> RegisteredUsers = new SortedDictionary<string, string>();
            Dictionary<string, string> RegisteredUsers = new Dictionary<string, string>();
            //SortedSet<string> LoggedInUsers = new SortedSet<string>();
            List<string> LoggedInUsers = new List<string>();
            string[] input = new string[3];
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                if (input[0] == "register")
                {
                    if (RegisteredUsers.ContainsKey(input[1]))
                        Console.WriteLine("fail: user already exists");
                    else
                    {
                        RegisteredUsers.Add(input[1], input[2]);
                        Console.WriteLine("success: new user added");
                    }
                }
                else if (input[0] == "login")
                {
                    string pass = RegisteredUsers.ContainsKey(input[1]) ? RegisteredUsers[input[1]] : string.Empty;
                    if (pass == string.Empty)
                        Console.WriteLine("fail: no such user");
                    else if (pass != input[2])
                        Console.WriteLine("fail: incorrect password");
                    else if (LoggedInUsers.Contains(input[1]))
                        Console.WriteLine("fail: already logged in");
                    else
                    {
                        LoggedInUsers.Add(input[1]);
                        Console.WriteLine("success: user logged in");
                    }

                }
                else if (input[0] == "logout")
                {
                    if (!RegisteredUsers.ContainsKey(input[1]))
                        Console.WriteLine("fail: no such user");
                    else if (!LoggedInUsers.Contains(input[1]))
                        Console.WriteLine("fail: already logged out");
                    else
                    {
                        Console.WriteLine("success: user logged out");
                        LoggedInUsers.Remove(input[1]);
                    }
                }
            }
        }
    }
}
