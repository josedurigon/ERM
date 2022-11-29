using Afosy.Cadastros;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afosy
{
    public partial class PAGINA_LOGIN : Form
    {
        public PAGINA_LOGIN()
        {
            InitializeComponent();
        }

        private void BOTAO_ENTRAR_Click(object sender, EventArgs e)
        {
            MONITORAMENTO PaginaMonitoramento = new MONITORAMENTO();
            PaginaMonitoramento.Show();
            this.Hide();
            //Fazer a validação do login e senha. Executar o comando para consultar no banco de dados se o informado bate. Ja seta o login e senha pros 3

            //SELECT SENHA FROM USUARIOS
            //WHERE LOGIN_ =
            /*
            using (SqlConnection cn = new SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB")))
            {
                cn.Open();
                string comando = $"SELECT SENHA FROM USUARIOS WHERE LOGIN_ = '{LOGIN_CAIXA.Text}'";


                SqlCommand command = new SqlCommand(comando,cn);
                
                
                string senha = command.ExecuteScalar().ToString();
                try
                {
                    if (SENHA_CAIXA.Text != senha || SENHA_CAIXA.Text == null)
                    {
                        MessageBox.Show("Erro, usuário não encontrado", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BOTAO_ENTRAR.Enabled = false;
                        BOTAO_ENTRAR.Refresh();
                        Application.Exit();
                    }
                    else
                    {
                        BOTAO_ENTRAR.Enabled = true;
                        BOTAO_ENTRAR.Refresh();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar se conectar", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                                
           }*/
        }//-----

        private void linkEsqueciMinhaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //esqueci minha senha. Redirecionar para o site 
        }

        private void linkCadastrarPaginaLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //redirecionar para página web de cadastro DO SITE
        }
    }
}
