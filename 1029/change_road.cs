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
    public partial class change_road : Form
    {
        static string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public change_road()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (docs_folder_road.Text == "")
            {
                MessageBox.Show("Небольшая ошибка", "Сообщения");
            }
            else
            {
                File.WriteAllText(Path.Combine(folderpath, "documentation_folder_road"), docs_folder_road.Text);
                MessageBox.Show("Действие выполнено!", "Сообщение");
                Application.Restart();
            }
        }
    }
}
