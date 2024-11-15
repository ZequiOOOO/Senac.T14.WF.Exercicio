namespace WF.Memoria
{
    public partial class Form1 : Form
    {
        // Lista com pares e um coringa 
        private List<string> valores = new List<string>
        { "A","A","B","B","C","C", "D","D","E","E","F","F","G","G","H","H"
        };
        //2 botões de clique
        private Button primeiroClique, segundoClique;

        //gerador de numero randomico
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            DistribuirLetras();
        }

        private void DistribuirLetras()
        {
            //percorrer os botões que estão dentro do tablelay
            foreach (Control controle in tableLayoutPanel1.Controls)
            {
                if (controle is Button botao)
                {
                    //gera um numero aleatorio ate 16 = 4
                    int indiceAleatorio = random.Next(valores.Count);
                    //determina o texto do botão = B
                    botao.Text = valores[indiceAleatorio];
                    // definir cor do texto igual cor do fundo
                    botao.ForeColor = botao.BackColor = Color.Red;
                    // remover o valor ja usado
                    valores.RemoveAt(indiceAleatorio);
                    // adicionar o evento de clique
                    botao.Click += botao_click;
                }

            }
        }
        private void botao_click(object sender, EventArgs e)
        {
            if (primeiroClique != null && segundoClique != null)
                return;
            Button botaoClicado = sender as Button;
            if (botaoClicado == null || botaoClicado.ForeColor == Color.Black)
                return;

            botaoClicado.ForeColor = Color.Black;

            if (primeiroClique == null)
            {
                primeiroClique = botaoClicado;
                return;
            }
            segundoClique = botaoClicado;
            if (primeiroClique.Text == segundoClique.Text && primeiroClique != segundoClique)
            {
                primeiroClique = null;
                segundoClique = null;
                VerificarVitoria();
            }
            else
            {
                
                segundoClique.ForeColor = Color.Black;
                Thread.Sleep(1000);
                primeiroClique.ForeColor = segundoClique.BackColor;
                segundoClique.ForeColor = segundoClique.BackColor;
                primeiroClique = null;
                segundoClique = null;
            }
        } // Fim botao_click

        private void VerificarVitoria()
        {
            
        }

    } // Fim classe
}





