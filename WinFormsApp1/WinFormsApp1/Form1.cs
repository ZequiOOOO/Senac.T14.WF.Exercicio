namespace WinFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmUserOne frmUserOne = new FrmUserOne();
            frmUserOne.Show();
        }

        private void BtnUsuarioTwo_Click(object sender, EventArgs e)
        {
            FrmUserTwo frmUserTwo = new FrmUserTwo();
            frmUserTwo.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

} 
