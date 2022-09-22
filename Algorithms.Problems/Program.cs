using Algorithms.Problems.Timus.GraphTheory;
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

            _1160_Network.main();

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
