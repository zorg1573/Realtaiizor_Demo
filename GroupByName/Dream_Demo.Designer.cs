namespace realtaiizorDemo
{
    partial class Dream_Demo
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
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            dreamProgressBar1 = new ReaLTaiizor.Controls.DreamProgressBar();
            dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            dreamTextBox1 = new ReaLTaiizor.Controls.DreamTextBox();
            dreamForm1.SuspendLayout();
            SuspendLayout();
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(dreamTextBox1);
            dreamForm1.Controls.Add(dreamProgressBar1);
            dreamForm1.Controls.Add(dreamButton1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(800, 450);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "dreamForm1";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // dreamProgressBar1
            // 
            dreamProgressBar1.ColorA = Color.FromArgb(31, 31, 31);
            dreamProgressBar1.ColorB = Color.FromArgb(41, 41, 41);
            dreamProgressBar1.ColorC = Color.FromArgb(51, 51, 51);
            dreamProgressBar1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamProgressBar1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamProgressBar1.Location = new Point(28, 136);
            dreamProgressBar1.Name = "dreamProgressBar1";
            dreamProgressBar1.Size = new Size(100, 23);
            dreamProgressBar1.TabIndex = 1;
            dreamProgressBar1.Value = 50;
            // 
            // dreamButton1
            // 
            dreamButton1.ColorA = Color.FromArgb(31, 31, 31);
            dreamButton1.ColorB = Color.FromArgb(41, 41, 41);
            dreamButton1.ColorC = Color.FromArgb(51, 51, 51);
            dreamButton1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamButton1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamButton1.ForeColor = Color.FromArgb(40, 218, 255);
            dreamButton1.Location = new Point(28, 58);
            dreamButton1.Name = "dreamButton1";
            dreamButton1.Size = new Size(120, 40);
            dreamButton1.TabIndex = 0;
            dreamButton1.Text = "dreamButton1";
            dreamButton1.UseVisualStyleBackColor = true;
            // 
            // dreamTextBox1
            // 
            dreamTextBox1.BackColor = Color.FromArgb(41, 41, 41);
            dreamTextBox1.BorderStyle = BorderStyle.FixedSingle;
            dreamTextBox1.ColorA = Color.FromArgb(31, 31, 31);
            dreamTextBox1.ColorB = Color.FromArgb(41, 41, 41);
            dreamTextBox1.ColorC = Color.FromArgb(51, 51, 51);
            dreamTextBox1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamTextBox1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamTextBox1.ColorF = Color.Black;
            dreamTextBox1.ForeColor = Color.FromArgb(40, 218, 255);
            dreamTextBox1.Location = new Point(28, 193);
            dreamTextBox1.Name = "dreamTextBox1";
            dreamTextBox1.Size = new Size(100, 23);
            dreamTextBox1.TabIndex = 2;
            dreamTextBox1.Text = "textBox";
            // 
            // DreamForm_Demo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DreamForm_Demo";
            Text = "DreamForm_Demo";
            dreamForm1.ResumeLayout(false);
            dreamForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private ReaLTaiizor.Controls.DreamProgressBar dreamProgressBar1;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private ReaLTaiizor.Controls.DreamTextBox dreamTextBox1;
    }
}