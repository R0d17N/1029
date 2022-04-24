using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _1029
{
    public partial class doc : Form
    {
        static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string path_en = "доп.файлы\\документация\\documentation.txt";
        static string path_ru = "доп.файлы\\документация\\документация.txt";

        public doc()
        {
            InitializeComponent();

            Documentation.ReadOnly = true;

            try
            {
                string lang = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "doc_lang"));

                if (lang == "en")
                {
                    Documentation.Text = File.ReadAllText(path_en);
                }
                else
                {
                    Documentation.Text = File.ReadAllText(path_ru);
                }
                File.WriteAllText(@"доп.файлы\comand_txt.txt", Documentation.Text);
            }
            catch(Exception ex)
            {
                Documentation.Text = "Error:\n\n" + ex.ToString();
            }
        }

        // save documantation file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lang = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "doc_lang"));

            if (lang == "en")
            {
                File.WriteAllText(path_en, Documentation.Text);
            }
            else
            {
                File.WriteAllText(path_ru, Documentation.Text);
            }

            MessageBox.Show("Файл успешно сохранен!", "Сообщение");
        }
        
        // open ru doc in txt
        private void rudoctxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = path_ru;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        // open en doc in txt
        private void endoctxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = path_en;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        // change text size
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Documentation.Font = new Font(Documentation.Font.FontFamily, 12f, Documentation.Font.Style);
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Documentation.Font = new Font(Documentation.Font.FontFamily, 14f, Documentation.Font.Style);
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Documentation.Font = new Font(Documentation.Font.FontFamily, 16f, Documentation.Font.Style);
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Documentation.Font = new Font(Documentation.Font.FontFamily, 18f, Documentation.Font.Style);
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Documentation.Font = new Font(Documentation.Font.FontFamily, 22f, Documentation.Font.Style);
        }

        // change background color
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentation.BackColor = Color.Black;
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentation.BackColor = Color.Red;
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentation.BackColor = Color.Green;
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentation.BackColor = Color.Blue;
        }

        // change language
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(@"C:\Users\Rodion\Desktop\comand_txt.txt", Documentation.Text);
                string lang = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "doc_lang"));
                if (lang == "en")
                {
                    File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "doc_lang"), "ru");
                    Documentation.Text = File.ReadAllText(path_ru);
                }
                else
                {
                    File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "doc_lang"), "en");
                    Documentation.Text = File.ReadAllText(path_en);
                }
            }
            catch(Exception ex)
            {
                Documentation.Text = "Error:\n\n" + ex.ToString();
            }
        }

        // change text color
        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Documentation.ForeColor = Color.Black;
        }
        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Documentation.ForeColor = Color.Red;
        }
        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Documentation.ForeColor = Color.Green;
        }
        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Documentation.ForeColor = Color.Blue;
        }

        // readonly
        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentation.ReadOnly = true;
        }
        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentation.ReadOnly = false;
        }
    }
}