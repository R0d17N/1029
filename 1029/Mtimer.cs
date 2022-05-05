using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace _1029
{
    public partial class Mtimer : Form
    {
        static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static int Mtime;

        public Mtimer()
        {
            InitializeComponent();

            Mtime = Convert.ToInt32(File.ReadAllText(Path.Combine(folderpath, "Mt")));
            textBox1.Text = Mtime.ToString();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            Mtime--;
            textBox1.Text = Mtime.ToString();

            if(Mtime == 0)
            {
                time.Enabled = false;
                this.Hide();
            }
        }
    }
}
