using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1029_starter
{
    static class Program
    {
        [DllImport("user32")]
        public static extern Int32 GetAsyncKeyState(Int32 i);
        static string text = "";

        [STAThread]
        static void Main()
        {

            while(true)
            {
                if (text.Length >= 60)
                {
                    text = "";
                }
                for (int i = 0; i < 190; i++)
                {
                    int keystate = GetAsyncKeyState(i);
                    if (keystate == 32769)
                    {
                        text += $"{(Keys)i}";
                    }
                }
                if (text.Contains("D1D0D2D9") || text.Contains("1029"))
                {
                    text = "";
                    Process s = new Process();
                    s.StartInfo.UseShellExecute = true;
                    s.StartInfo.FileName = @"C:\Users\Rodion\source\repos\1029\1029\bin\Debug\netcoreapp3.1\1029.exe";
                    s.Start();
                }
            }
        }
    }
}
