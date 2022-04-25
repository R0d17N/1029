
namespace _1029_starter
{
    partial class Form1
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
            this.buttons_checker = new System.Windows.Forms.Timer(this.components);
            this.inp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttons_checker
            // 
            this.buttons_checker.Enabled = true;
            this.buttons_checker.Interval = 1;
            this.buttons_checker.Tick += new System.EventHandler(this.buttons_checker_Tick);
            // 
            // inp
            // 
            this.inp.Location = new System.Drawing.Point(158, 57);
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(340, 23);
            this.inp.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 245);
            this.Controls.Add(this.inp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer buttons_checker;
        private System.Windows.Forms.TextBox inp;
    }
}

