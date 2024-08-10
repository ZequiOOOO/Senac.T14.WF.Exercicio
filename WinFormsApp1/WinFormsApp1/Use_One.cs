using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmUserOne : Form
    {
        public FrmUserOne()
        {
            InitializeComponent();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            using (var contexto = new Banco())
            {
                var usuario = new User { Nome = "John Doe" }; // cria um novo usuario
                contexto.Users.Add(usuario); // adiciona o usuário no contexto do banco
                contexto.SaveChanges(); // executa o script de insert no banco de dados
            }
        }

        private void FrmUserOne_Load(object sender, EventArgs e)
        {

        }
    }
}
