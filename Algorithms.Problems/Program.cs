using Algorithms.Problems.Timus.DynamicProgramming;
using Algorithms.Problems.Timus.General;
using Algorithms.Problems.Timus.GraphTheory;
using Algorithms.Problems.Timus.NumberTheory;
using Algorithms.Problems.WorkingProblems;
using Algorithms.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startInput();

            _1297_Palindrome.main();

            Console.ReadLine();
        }

        static async void startInput()
        {
            await Task.Factory.StartNew(() =>
            {
                var frmInput = new FrmInput();
                frmInput.ShowDialog();
            });
        }
    }
}
