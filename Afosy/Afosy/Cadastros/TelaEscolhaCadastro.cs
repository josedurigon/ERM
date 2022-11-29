using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afosy.Cadastros
{
    public partial class TelaEscolhaCadastro : Form
    {
        public TelaEscolhaCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarHospital_Click(object sender, EventArgs e)
        {
            CadastroHospital cadastroHospital = new CadastroHospital();
            cadastroHospital.Show();
            this.Close();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Cadastro cadastrarusuario = new Cadastro();
            cadastrarusuario.Show();
            this.Close();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
            this.Close();
        }
    }
}
