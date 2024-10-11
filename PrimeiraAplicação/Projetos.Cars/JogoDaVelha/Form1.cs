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
                jogador1 = "X";
                jogador2 = "O";
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
        }
    }
}
