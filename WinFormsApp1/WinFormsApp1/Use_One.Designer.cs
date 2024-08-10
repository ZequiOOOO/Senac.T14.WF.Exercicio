namespace WinFormsApp1
{
    partial class FrmUserOne
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
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(494, 85);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(150, 68);
            airButton1.TabIndex = 0;
            airButton1.Text = "airButton1";
            airButton1.Transparent = false;
            airButton1.Click += airButton1_Click;
            // 
            // FrmUserOne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(airButton1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmUserOne";
            Text = "User One";
            Load += FrmUserOne_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton airButton1;
    }
}