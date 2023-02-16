using System;
using System.Threading.Tasks;

using Algorithms.Problems.WorkingProblems;
using Algorithms.Utils;

namespace Algorithms.Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startInput();

            _1119_Metro.main();

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
