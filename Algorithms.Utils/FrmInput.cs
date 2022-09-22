using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Utils
{
    public partial class FrmInput : Form
    {
        public FrmInput()
        {
            InitializeComponent();
        }

        public const Int32 WM_CHAR = 0x0102;
        public const Int32 WM_KEYDOWN = 0x0100;
        public const Int32 WM_KEYUP = 0x0101;
        public const Int32 VK_RETURN = 0x0D;


        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr PostMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);


        private void btnSend_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = FindWindow("ConsoleWindowClass", null);

            byte[] asciiBytes = Encoding.ASCII.GetBytes(rtb_text.Text);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                if (asciiBytes[i] != (byte)'\r' && asciiBytes[i] != (byte)'\n')
                    PostMessage(hwnd, WM_CHAR, new IntPtr(asciiBytes[i]), (IntPtr)0);

                if (asciiBytes[i] == (byte)'\r' || asciiBytes[i] == (byte)'\n')
                {
                    PostMessage(hwnd, WM_KEYDOWN, new IntPtr(VK_RETURN), (IntPtr)0);
                }

                Thread.Sleep(10);
            }
        }
    }
}
