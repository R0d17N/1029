using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _1029
{
    public partial class StopWatch : Form
    {
        static int h = 0, m = 0, s = 0;
        static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public StopWatch()
        {
            InitializeComponent();

            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "work"), "");
            try
            {
                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "pause"));
            }
            catch
            {
                Console.WriteLine("err");
            }

            h = 0;
            m = 0;
            s = 0;
        }

        private void stopwather_Tick(object sender, EventArgs e)
        {
            s++;
            if (s == 60)
            {
                s = 0;
                m++;
            }
            if (m == 60)
            {
                m = 0;
                h++;
            }


            if (h <= 9)
            {
                textBox1.Text = "0" + h + ":";
            }
            else
            {
                textBox1.Text += h + ":";
            }
            if (m <= 9)
            {
                textBox1.Text += "0" + m + ":";
            }
            else
            {
                textBox1.Text += m + ":";
            }
            if (s <= 9)
            {
                textBox1.Text += "0" + s;
                Console.WriteLine("\a");
            }
            else
            {
                textBox1.Text += s;
            }
        }

        private void pause_timer_Tick(object sender, EventArgs e)
        {
            if(File.Exists(Path.Combine(folderpath, "pause")))
            {
                stopwather.Stop();
            }
            else if(File.Exists(Path.Combine(folderpath, "work")))
            {
                stopwather.Start();
            }
        }
    }
}
