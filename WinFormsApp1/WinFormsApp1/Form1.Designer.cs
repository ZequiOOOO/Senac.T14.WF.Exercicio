namespace WinFormsApp1
{
    partial class FrmPrincipal
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
            BtnTelaPrincipal = new ReaLTaiizor.Controls.CrownGroupBox();
            BtnUsuarioTwo = new ReaLTaiizor.Controls.Button();
            BtnUsuario = new ReaLTaiizor.Controls.Button();
            BtnSair = new ReaLTaiizor.Controls.CyberButton();
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            BtnTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // BtnTelaPrincipal
            // 
            BtnTelaPrincipal.BorderColor = Color.FromArgb(51, 51, 51);
            BtnTelaPrincipal.Controls.Add(BtnUsuarioTwo);
            BtnTelaPrincipal.Controls.Add(BtnUsuario);
            BtnTelaPrincipal.Controls.Add(BtnSair);
            BtnTelaPrincipal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnTelaPrincipal.Location = new Point(91, 41);
            BtnTelaPrincipal.Name = "BtnTelaPrincipal";
            BtnTelaPrincipal.Size = new Size(615, 364);
            BtnTelaPrincipal.TabIndex = 0;
            BtnTelaPrincipal.TabStop = false;
            BtnTelaPrincipal.Text = "Tela Principal";
            // 
            // BtnUsuarioTwo
            // 
            BtnUsuarioTwo.BackColor = Color.Transparent;
            BtnUsuarioTwo.BorderColor = Color.FromArgb(32, 34, 37);
            BtnUsuarioTwo.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            BtnUsuarioTwo.EnteredColor = Color.FromArgb(32, 34, 37);
            BtnUsuarioTwo.Font = new Font("Microsoft Sans Serif", 12F);
            BtnUsuarioTwo.Image = null;
            BtnUsuarioTwo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUsuarioTwo.InactiveColor = Color.FromArgb(32, 34, 37);
            BtnUsuarioTwo.Location = new Point(325, 118);
            BtnUsuarioTwo.Name = "BtnUsuarioTwo";
            BtnUsuarioTwo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            BtnUsuarioTwo.PressedColor = Color.FromArgb(165, 37, 37);
            BtnUsuarioTwo.Size = new Size(199, 102);
            BtnUsuarioTwo.TabIndex = 3;
            BtnUsuarioTwo.Text = "User Two";
            BtnUsuarioTwo.TextAlignment = StringAlignment.Center;
            BtnUsuarioTwo.Click += BtnUsuarioTwo_Click;
            // 
            // BtnUsuario
            // 
            BtnUsuario.BackColor = Color.Transparent;
            BtnUsuario.BorderColor = Color.FromArgb(32, 34, 37);
            BtnUsuario.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            BtnUsuario.EnteredColor = Color.FromArgb(32, 34, 37);
            BtnUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            BtnUsuario.Image = null;
            BtnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUsuario.InactiveColor = Color.FromArgb(32, 34, 37);
            BtnUsuario.Location = new Point(88, 118);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.PressedBorderColor = Color.FromArgb(165, 37, 37);
            BtnUsuario.PressedColor = Color.FromArgb(165, 37, 37);
            BtnUsuario.Size = new Size(199, 102);
            BtnUsuario.TabIndex = 2;
            BtnUsuario.Text = "User One";
            BtnUsuario.TextAlignment = StringAlignment.Center;
            BtnUsuario.Click += button1_Click;
            // 
            // BtnSair
            // 
            BtnSair.Alpha = 20;
            BtnSair.BackColor = Color.Transparent;
            BtnSair.Background = true;
            BtnSair.Background_WidthPen = 4F;
            BtnSair.BackgroundPen = true;
            BtnSair.ColorBackground = Color.FromArgb(37, 52, 68);
            BtnSair.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            BtnSair.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BtnSair.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            BtnSair.ColorLighting = Color.FromArgb(29, 200, 238);
            BtnSair.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BtnSair.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BtnSair.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnSair.Effect_1 = true;
            BtnSair.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BtnSair.Effect_1_Transparency = 25;
            BtnSair.Effect_2 = true;
            BtnSair.Effect_2_ColorBackground = Color.White;
            BtnSair.Effect_2_Transparency = 20;
            BtnSair.Font = new Font("Arial", 11F);
            BtnSair.ForeColor = Color.FromArgb(245, 245, 245);
            BtnSair.Lighting = false;
            BtnSair.LinearGradient_Background = false;
            BtnSair.LinearGradientPen = false;
            BtnSair.Location = new Point(20, 313);
            BtnSair.Name = "BtnSair";
            BtnSair.PenWidth = 15;
            BtnSair.Rounding = true;
            BtnSair.RoundingInt = 70;
            BtnSair.Size = new Size(87, 45);
            BtnSair.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnSair.TabIndex = 0;
            BtnSair.Tag = "Cyber";
            BtnSair.TextButton = "Sair";
            BtnSair.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnSair.Timer_Effect_1 = 5;
            BtnSair.Timer_RGB = 300;
            BtnSair.Click += BtnSair_Click;
            // 
            // poisonDateTime1
            // 
            poisonDateTime1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poisonDateTime1.Format = DateTimePickerFormat.Time;
            poisonDateTime1.Location = new Point(-1, 421);
            poisonDateTime1.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(81, 29);
            poisonDateTime1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            poisonDateTime1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(poisonDateTime1);
            Controls.Add(BtnTelaPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            BtnTelaPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CrownGroupBox BtnTelaPrincipal;
        private ReaLTaiizor.Controls.Button BtnUsuario;
        private ReaLTaiizor.Controls.CyberButton BtnSair;
        private ReaLTaiizor.Controls.Button BtnUsuarioTwo;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
    }
}
