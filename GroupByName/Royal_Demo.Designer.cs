namespace realtaiizorDemo
{
    partial class Royal_Demo
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
            royalButton1 = new ReaLTaiizor.Controls.RoyalButton();
            royalEllipseButton1 = new ReaLTaiizor.Controls.RoyalEllipseButton();
            royalListBox1 = new ReaLTaiizor.Controls.RoyalListBox();
            royalScrollBar1 = new ReaLTaiizor.Controls.RoyalScrollBar();
            separator1 = new ReaLTaiizor.Controls.Separator();
            SuspendLayout();
            // 
            // royalButton1
            // 
            royalButton1.BackColor = Color.FromArgb(243, 243, 243);
            royalButton1.BorderColor = Color.FromArgb(180, 180, 180);
            royalButton1.BorderThickness = 3;
            royalButton1.DrawBorder = true;
            royalButton1.ForeColor = Color.FromArgb(31, 31, 31);
            royalButton1.HotTrackColor = Color.FromArgb(221, 221, 221);
            royalButton1.Image = null;
            royalButton1.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            royalButton1.Location = new Point(16, 17);
            royalButton1.Name = "royalButton1";
            royalButton1.PressedColor = Color.FromArgb(51, 102, 255);
            royalButton1.PressedForeColor = Color.White;
            royalButton1.Size = new Size(120, 40);
            royalButton1.TabIndex = 0;
            royalButton1.Text = "royalButton1";
            // 
            // royalEllipseButton1
            // 
            royalEllipseButton1.BackColor = Color.FromArgb(243, 243, 243);
            royalEllipseButton1.BorderColor = Color.FromArgb(180, 180, 180);
            royalEllipseButton1.BorderThickness = 3;
            royalEllipseButton1.DrawBorder = true;
            royalEllipseButton1.ForeColor = Color.FromArgb(31, 31, 31);
            royalEllipseButton1.HotTrackColor = Color.FromArgb(221, 221, 221);
            royalEllipseButton1.Image = null;
            royalEllipseButton1.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            royalEllipseButton1.Location = new Point(16, 63);
            royalEllipseButton1.Name = "royalEllipseButton1";
            royalEllipseButton1.PressedColor = Color.FromArgb(51, 102, 255);
            royalEllipseButton1.PressedForeColor = Color.White;
            royalEllipseButton1.Size = new Size(120, 120);
            royalEllipseButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            royalEllipseButton1.TabIndex = 1;
            royalEllipseButton1.Text = "royalEllipseButton1";
            // 
            // royalListBox1
            // 
            royalListBox1.HotLightColor = Color.FromArgb(221, 221, 221);
            royalListBox1.HotLightedIndex = -1;
            royalListBox1.ItemHeight = 30;
            royalListBox1.Location = new Point(16, 209);
            royalListBox1.MultiSelection = false;
            royalListBox1.Name = "royalListBox1";
            royalListBox1.SelectedColor = Color.FromArgb(51, 102, 255);
            royalListBox1.SelectedIndex = -1;
            royalListBox1.Size = new Size(120, 45);
            royalListBox1.TabIndex = 2;
            royalListBox1.Text = "royalListBox1";
            // 
            // royalScrollBar1
            // 
            royalScrollBar1.GutterColor = Color.FromArgb(221, 221, 221);
            royalScrollBar1.LargeChange = 50;
            royalScrollBar1.Location = new Point(16, 290);
            royalScrollBar1.Max = 1;
            royalScrollBar1.Min = 0;
            royalScrollBar1.Name = "royalScrollBar1";
            royalScrollBar1.Orientation = Orientation.Vertical;
            royalScrollBar1.Size = new Size(147, 23);
            royalScrollBar1.SmallChange = 10;
            royalScrollBar1.TabIndex = 3;
            royalScrollBar1.Text = "royalScrollBar1";
            royalScrollBar1.ThumbColor = Color.FromArgb(51, 102, 255);
            royalScrollBar1.Value = 0;
            // 
            // separator1
            // 
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(16, 341);
            separator1.Name = "separator1";
            separator1.Size = new Size(120, 10);
            separator1.TabIndex = 4;
            separator1.Text = "separator1";
            // 
            // Royal_Demo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(separator1);
            Controls.Add(royalScrollBar1);
            Controls.Add(royalListBox1);
            Controls.Add(royalEllipseButton1);
            Controls.Add(royalButton1);
            Name = "Royal_Demo";
            Text = "Royal_Demo";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.RoyalButton royalButton1;
        private ReaLTaiizor.Controls.RoyalEllipseButton royalEllipseButton1;
        private ReaLTaiizor.Controls.RoyalListBox royalListBox1;
        private ReaLTaiizor.Controls.RoyalScrollBar royalScrollBar1;
        private ReaLTaiizor.Controls.Separator separator1;
    }
}