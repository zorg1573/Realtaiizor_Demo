namespace realtaiizorDemo
{
    partial class FormTheme_Demo
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
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            ReaLTaiizor.ControlRenderer controlRenderer2 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable2 = new ReaLTaiizor.MSColorTable();
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            formStatusStrip1 = new ReaLTaiizor.Controls.FormStatusStrip();
            formMenuStrip1 = new ReaLTaiizor.Controls.FormMenuStrip();
            formTheme1.SuspendLayout();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Controls.Add(formStatusStrip1);
            formTheme1.Controls.Add(formMenuStrip1);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 28, 3, 28);
            formTheme1.Sizable = true;
            formTheme1.Size = new Size(800, 450);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            formTheme1.TabIndex = 0;
            formTheme1.Text = "formTheme1";
            // 
            // formStatusStrip1
            // 
            formStatusStrip1.Location = new Point(3, 400);
            formStatusStrip1.Name = "formStatusStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            formStatusStrip1.Renderer = controlRenderer1;
            formStatusStrip1.Size = new Size(794, 22);
            formStatusStrip1.SizingGrip = false;
            formStatusStrip1.TabIndex = 0;
            formStatusStrip1.Text = "formStatusStrip1";
            // 
            // formMenuStrip1
            // 
            formMenuStrip1.Location = new Point(3, 28);
            formMenuStrip1.Name = "formMenuStrip1";
            controlRenderer2.ColorTable = msColorTable2;
            controlRenderer2.RoundedEdges = true;
            formMenuStrip1.Renderer = controlRenderer2;
            formMenuStrip1.Size = new Size(794, 24);
            formMenuStrip1.TabIndex = 1;
            formMenuStrip1.Text = "formMenuStrip1";
            // 
            // FormThemo_Demo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = formMenuStrip1;
            MinimumSize = new Size(126, 50);
            Name = "FormThemo_Demo";
            Text = "formTheme1";
            TransparencyKey = Color.Fuchsia;
            formTheme1.ResumeLayout(false);
            formTheme1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.FormStatusStrip formStatusStrip1;
        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip1;
    }
}