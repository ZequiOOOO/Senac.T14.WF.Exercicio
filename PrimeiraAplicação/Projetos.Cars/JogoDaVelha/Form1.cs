using System.Diagnostics.Eventing.Reader;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        // Button[] botoes = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        string turno = "j1";
        string jogador1 = "";
        string jogador2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparTabuleiro(false);
        }

        private void LimparTabuleiro(bool habilita)
        {
            btn1.Text = string.Empty;
            btn2.Text = string.Empty;
            btn3.Text = string.Empty;
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            btn8.Text = string.Empty;
            btn9.Text = string.Empty;
            btn1.Enabled = habilita;
            btn2.Enabled = habilita;
            btn3.Enabled = habilita;
            btn4.Enabled = habilita;
            btn5.Enabled = habilita;
            btn6.Enabled = habilita;
            btn7.Enabled = habilita;
            btn8.Enabled = habilita;
            btn9.Enabled = habilita;

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (jogador1 == "")
            {
                jogador1 = "X";
                jogador2 = "O";
                btnInic.Enabled = true;
                lblJogadorX.Text = "jogador1";
                lblJogadorO.Text = "jogador2";
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (jogador1 == string.Empty)

            {
                jogador1 = "O";
                jogador2 = "X";
                btnInic.Enabled = true;
                lblJogadorO.Text = "Jogador1";
                lblJogadorX.Text = "Jogador2";

            }
        }

        private void btnInic_Click(object sender, EventArgs e)
        {
            turno = "j1";
            btnInic.Enabled = false;
            LimparTabuleiro(true);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn1.Text))
                return;
            if (turno == "j1")
            {
                btn1.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn1.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void VerificarVencedor()
        {
           if (btn1.Text == jogador1
             && btn2.Text == jogador1
             && btn3.Text == jogador1)
            {
                Resetarpartida(jogador1);
            }
        }

        private void Resetarpartida(string jogadorVitorioso)
        {
            turno = "j1";
            btnInic.Enabled = false;
            lblJogadorX.Text = "<<<";
            lblJogadorO.Text = ">>>";
            MessageBox.Show("Vitoria do jogador" + jogadorVitorioso);
            jogador1 = "";
            jogador2 = "";
            LimparTabuleiro(false);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // se o texto do btn não está vazio
            if (!string.IsNullOrEmpty(btn2.Text))
                return;

            if (turno == "j1")
            {
                btn2.Text = jogador1;
                turno = "j2";

            }
            else
            {
                btn2.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn3.Text))
                return;
            if (turno == "j1")
            {
                btn3.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn3.Text = jogador2;
                turno = "j1";
            }
            VerificarVencedor();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn4.Text))
                return;
            if (turno == "j1")
            {
                btn4.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn4.Text = jogador2;
                turno = "j1";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn5.Text))
                return;
            if (turno == "j1")
            {
                btn5.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn5.Text = jogador2;
                turno = "j1";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn6.Text))
                return;
            if (turno == "j1")
            {
                btn6.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn6.Text = jogador2;
                turno = "j1";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn7.Text))
                return;
            if (turno == "j1")
            {
                btn7.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn7.Text = jogador2;
                turno = "j1";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn8.Text))
                return;
            if (turno == "j1")
            {

                btn8.Text = jogador1;
                turno = "j2";
            }
            else
            {
                btn8.Text = jogador2;
                turno = "j1";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btn9.Text))
                return;
            if (turno == "j1")
            {  btn9.Text = jogador1;
               turno = "j2";
            }
            else 
            {
               btn9.Text = jogador2;
               turno = "j1";
            }
        }
    }
}
