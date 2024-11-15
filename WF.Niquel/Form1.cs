namespace WF.Niquel
{
    public partial class Form1 : Form
    {
        private Random randow = new();
        private int contador;
        private int coin;

        public Form1()
        {
            
            InitializeComponent();
            coin = 20;
            lblCoin.Text  = coin.ToString();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (coin <= 0)
            {
                MessageBox.Show("Você não possui moedas!");
                return;

            }

            contador = 0;
            label1.Text = "";
            coin--;
            lblCoin.Text = coin.ToString();
            timerSpin.Start();
        }

        private void timerSpin_Tick(object sender, EventArgs e)
        {
            int numeroRandomico = randow.Next(1, 9);
            btn1.Text = numeroRandomico.ToString();

            numeroRandomico = randow.Next(1, 9);
            btn2.Text = numeroRandomico.ToString();

            numeroRandomico = randow.Next(1,9);
            btn3.Text = numeroRandomico.ToString();

            contador++;

            if (contador >= 20)
            {
                timerSpin.Stop();
                //verifica se os tres valores são iguais
                if(btn1.Text == btn2.Text &&  btn2.Text == btn3.Text) 
                {
                    //exibir vitória
                    label1.Text = "VOCÊ VENCEU!";
                    coin += 5;
                    lblCoin.Text = coin.ToString();

                }
              
            }
        }
    }
}




