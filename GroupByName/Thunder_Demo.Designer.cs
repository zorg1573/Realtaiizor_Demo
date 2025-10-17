namespace realtaiizorDemo
{
    partial class Thunder_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thunder_Demo));
            thunderForm1 = new ReaLTaiizor.Forms.ThunderForm();
            thunderButton1 = new ReaLTaiizor.Controls.ThunderButton();
            thunderCheckBox1 = new ReaLTaiizor.Controls.ThunderCheckBox();
            thunderControlBox1 = new ReaLTaiizor.Controls.ThunderControlBox();
            thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderProgressBar1 = new ReaLTaiizor.Controls.ThunderProgressBar();
            thunderRadioButton1 = new ReaLTaiizor.Controls.ThunderRadioButton();
            thunderForm1.SuspendLayout();
            SuspendLayout();
            // 
            // thunderForm1
            // 
            thunderForm1.BodyColorA = Color.FromArgb(25, 25, 25);
            thunderForm1.BodyColorB = Color.FromArgb(30, 35, 48);
            thunderForm1.BodyColorC = Color.FromArgb(46, 46, 46);
            thunderForm1.BodyColorD = Color.FromArgb(50, 55, 58);
            thunderForm1.Controls.Add(thunderRadioButton1);
            thunderForm1.Controls.Add(thunderProgressBar1);
            thunderForm1.Controls.Add(thunderLabel1);
            thunderForm1.Controls.Add(thunderGroupBox1);
            thunderForm1.Controls.Add(thunderControlBox1);
            thunderForm1.Controls.Add(thunderCheckBox1);
            thunderForm1.Controls.Add(thunderButton1);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = (Image)resources.GetObject("thunderForm1.Image");
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(800, 450);
            thunderForm1.TabIndex = 0;
            thunderForm1.Text = "thunderForm1";
            // 
            // thunderButton1
            // 
            thunderButton1.BackColor = Color.Transparent;
            thunderButton1.ForeColor = Color.WhiteSmoke;
            thunderButton1.Location = new Point(27, 42);
            thunderButton1.Name = "thunderButton1";
            thunderButton1.Size = new Size(120, 40);
            thunderButton1.TabIndex = 0;
            thunderButton1.Text = "thunderButton1";
            // 
            // thunderCheckBox1
            // 
            thunderCheckBox1.BackColor = Color.Transparent;
            thunderCheckBox1.Checked = false;
            thunderCheckBox1.ForeColor = Color.WhiteSmoke;
            thunderCheckBox1.Location = new Point(27, 97);
            thunderCheckBox1.Name = "thunderCheckBox1";
            thunderCheckBox1.Size = new Size(135, 16);
            thunderCheckBox1.TabIndex = 1;
            thunderCheckBox1.Text = "thunderCheckBox1";
            // 
            // thunderControlBox1
            // 
            thunderControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            thunderControlBox1.BackColor = Color.Transparent;
            thunderControlBox1.DefaultLocation = true;
            thunderControlBox1.ForeColor = Color.FromArgb(174, 195, 30);
            thunderControlBox1.Location = new Point(27, 130);
            thunderControlBox1.Name = "thunderControlBox1";
            thunderControlBox1.Size = new Size(75, 23);
            thunderControlBox1.TabIndex = 2;
            thunderControlBox1.Text = "thunderControlBox1";
            // 
            // thunderGroupBox1
            // 
            thunderGroupBox1.BackColor = Color.Transparent;
            thunderGroupBox1.BodyColorA = Color.FromArgb(26, 26, 26);
            thunderGroupBox1.BodyColorB = Color.FromArgb(30, 30, 30);
            thunderGroupBox1.BodyColorC = Color.FromArgb(46, 46, 46);
            thunderGroupBox1.BodyColorD = Color.FromArgb(50, 55, 58);
            thunderGroupBox1.ForeColor = Color.WhiteSmoke;
            thunderGroupBox1.Location = new Point(27, 170);
            thunderGroupBox1.Name = "thunderGroupBox1";
            thunderGroupBox1.Size = new Size(132, 100);
            thunderGroupBox1.TabIndex = 3;
            thunderGroupBox1.Text = "thunderGroupBox1";
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(27, 289);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(96, 16);
            thunderLabel1.TabIndex = 4;
            thunderLabel1.Text = "thunderLabel1";
            // 
            // thunderProgressBar1
            // 
            thunderProgressBar1.BackColor = Color.Transparent;
            thunderProgressBar1.ForeColor = Color.WhiteSmoke;
            thunderProgressBar1.Location = new Point(27, 320);
            thunderProgressBar1.Maximum = 100;
            thunderProgressBar1.Name = "thunderProgressBar1";
            thunderProgressBar1.ShowPercentage = false;
            thunderProgressBar1.Size = new Size(132, 23);
            thunderProgressBar1.TabIndex = 5;
            thunderProgressBar1.Text = "thunderProgressBar1";
            thunderProgressBar1.Value = 0;
            // 
            // thunderRadioButton1
            // 
            thunderRadioButton1.BackColor = Color.Transparent;
            thunderRadioButton1.Checked = false;
            thunderRadioButton1.ForeColor = Color.WhiteSmoke;
            thunderRadioButton1.Location = new Point(27, 365);
            thunderRadioButton1.Name = "thunderRadioButton1";
            thunderRadioButton1.Size = new Size(160, 16);
            thunderRadioButton1.TabIndex = 6;
            thunderRadioButton1.Text = "thunderRadioButton1";
            // 
            // Thunder_Demo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Thunder_Demo";
            Text = "Thunder_Demo";
            TransparencyKey = Color.Fuchsia;
            thunderForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
        private ReaLTaiizor.Controls.ThunderRadioButton thunderRadioButton1;
        private ReaLTaiizor.Controls.ThunderProgressBar thunderProgressBar1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private ReaLTaiizor.Controls.ThunderControlBox thunderControlBox1;
        private ReaLTaiizor.Controls.ThunderCheckBox thunderCheckBox1;
        private ReaLTaiizor.Controls.ThunderButton thunderButton1;
    }
}