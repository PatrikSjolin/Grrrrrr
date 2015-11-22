using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Grrrrrr
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Grrrrrr";
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);

            new Menu().Start();
        }
    }
}