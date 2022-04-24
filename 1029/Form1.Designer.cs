
namespace _1029
{
    partial class terminal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(terminal));
            this.input = new System.Windows.Forms.RichTextBox();
            this.file_writer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Black;
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input.ForeColor = System.Drawing.Color.Green;
            this.input.Location = new System.Drawing.Point(0, 0);
            this.input.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(714, 277);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // file_writer
            // 
            this.file_writer.Enabled = true;
            this.file_writer.Interval = 20;
            this.file_writer.Tick += new System.EventHandler(this.file_writer_Tick);
            // 
            // terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 277);
            this.Controls.Add(this.input);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "terminal";
            this.Text = "Terminal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Timer file_writer;
    }
}

