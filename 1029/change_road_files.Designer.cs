
namespace _1029
{
    partial class change_road_files
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.files_folder_road = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изменить путь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // files_folder_road
            // 
            this.files_folder_road.Location = new System.Drawing.Point(12, 12);
            this.files_folder_road.Name = "files_folder_road";
            this.files_folder_road.PlaceholderText = "Введите путь папки с фаайлами (имена: \"документация\" и \"file\")";
            this.files_folder_road.Size = new System.Drawing.Size(470, 23);
            this.files_folder_road.TabIndex = 3;
            this.files_folder_road.TextChanged += new System.EventHandler(this.files_folder_road_TextChanged);
            // 
            // change_road_files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 99);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.files_folder_road);
            this.Name = "change_road_files";
            this.Text = "change_road_files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox files_folder_road;
    }
}