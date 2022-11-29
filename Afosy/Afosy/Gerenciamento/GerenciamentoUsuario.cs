using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afosy.Gerenciamento
{
    public partial class GerenciamentoUsuario: Form
    {
        public GerenciamentoUsuario()
        {
            InitializeComponent();
        }

        private void labelExibirUsuario_Click(object sender, EventArgs e)
        {
            labelExibirUsuario.Text  = txtbxNomeUsuariosAtualizacaoDados.Text;
            labelExibirUsuario.Refresh();
        }
    }
}
