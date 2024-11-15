namespace WF.Niquel
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
            components = new System.ComponentModel.Container();
            btn1 = new Button();
            btnJogar = new Button();
            timerSpin = new System.Windows.Forms.Timer(components);
            btn2 = new Button();
            btn3 = new Button();
            label1 = new Label();
            lbllaaaaa = new Label();
            lblCoin = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(22, 157);
            btn1.Name = "btn1";
            btn1.Size = new Size(230, 198);
            btn1.TabIndex = 0;
            btn1.Text = "0";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            btnJogar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJogar.Location = new Point(22, 30);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(230, 49);
            btnJogar.TabIndex = 1;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // timerSpin
            // 
            timerSpin.Tick += timerSpin_Tick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.DarkBlue;
            btn2.Location = new Point(285, 157);
            btn2.Name = "btn2";
            btn2.Size = new Size(230, 198);
            btn2.TabIndex = 2;
            btn2.Text = "0";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.MediumBlue;
            btn3.Location = new Point(547, 157);
            btn3.Name = "btn3";
            btn3.Size = new Size(230, 198);
            btn3.TabIndex = 3;
            btn3.Text = "0";
            btn3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(52, 377);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // lbllaaaaa
            // 
            lbllaaaaa.AutoSize = true;
            lbllaaaaa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbllaaaaa.Location = new Point(489, 30);
            lbllaaaaa.Name = "lbllaaaaa";
            lbllaaaaa.Size = new Size(90, 38);
            lbllaaaaa.TabIndex = 5;
            lbllaaaaa.Text = "Coin: ";
            // 
            // lblCoin
            // 
            lblCoin.AutoSize = true;
            lblCoin.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCoin.Location = new Point(610, 30);
            lblCoin.Name = "lblCoin";
            lblCoin.Size = new Size(33, 38);
            lblCoin.TabIndex = 6;
            lblCoin.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCoin);
            Controls.Add(lbllaaaaa);
            Controls.Add(label1);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnJogar);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btnJogar;
        private System.Windows.Forms.Timer timerSpin;
        private Button btn2;
        private Button btn3;
        private Label label1;
        private Label lbllaaaaa;
        private Label lblCoin;
    }
}
