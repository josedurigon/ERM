using Afosy.Cadastros;
using Afosy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afosy
{
    public partial class MONITORAMENTO : Form
    {
        //criar uma lista que vai pegar todos os beneficiários pra depois exibir na listbox1
        public List<Beneficiario> beneficiarios = new List<Beneficiario>();


        public MONITORAMENTO()
        {
            InitializeComponent();
            
        }
        public string proccedure = "";
        public string contato = "contato@afcontultoriaeauditoria.com";

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                //toolStripStatusConexaoDB -- texto
                //toolStripProgressBarConexaoDB -- barra de progresso
                toolStripStatusConexaoDB.Text = "Conectando...";
                toolStripProgressBarConexaoDB.Value = 0;
                statusStrip1.Refresh();
                using (SqlConnection cn = new SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB")))
                {
                    cn.Open();
                    toolStripStatusConexaoDB.Text = "Conectado ao servidor";
                    toolStripProgressBarConexaoDB.Value = 100;
                    statusStrip1.Refresh();
                    //var sqlQuery = "SELECT * FROM BENEFICIARIOS";
                    var proccedure = "dbo.spBENEFICIARIOS_PEGARTODOS";
                    using (SqlDataAdapter da = new SqlDataAdapter(proccedure, cn))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridViewMonitoramento.DataSource = dt;
                            
                        }
                        
                        toolStripStatusConexaoDB.Text = "Pronto";
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar com banco de dados. Tente novamente mais tarde.\n" +
                    $"Se o problema persistir entre em contato com o suporte: {contato}",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void btnProcurarCaixa_Click(object sender, EventArgs e)
        {
            try
            {

            

                string item = comboBoxSelecionarFiltroMonitoramento.SelectedItem.ToString();//EXCEÇAÕ DE NULLREFERENCE
           

                for (int i=0; i<11; i++)
                {
                    if (item == BuscaPorSelecao.Itens[i])
                    {
                        proccedure = BuscaPorSelecao.Procedures[i];
                    }
                }
                item = string.Empty;//reseta a string empty pro usuario conseguir colocar outros campos, senão ele fica travado no primeiro campo que ele escolheu 
            
            
            
                toolStripStatusConexaoDB.Text = "Conectando...";
                toolStripProgressBarConexaoDB.Value = 0;
                statusStrip1.Refresh();
                using (SqlConnection cn = new SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB")))
                {
                    cn.Open();
                    toolStripStatusConexaoDB.Text = "Conectado ao servidor";
                    toolStripProgressBarConexaoDB.Value = 100;
                    statusStrip1.Refresh();

                   // var proccedure = "dbo.spBENEFICIARIOS_PEGARTUDOPELOSOBRENOME"+$"'{CaixaProcura.Text}'";
                    string comando = proccedure + $"'{CaixaProcura.Text}'";
                    
                    using (SqlDataAdapter da = new SqlDataAdapter(comando, cn))
                    {

                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridViewMonitoramento.DataSource = dt;
                        }
                    }

                }
            }
            catch (NullReferenceException ex)

            {

                MessageBox.Show($"Por favor, selecione um campo para especificar a pesquisa:{ex} ", "Erro de referência nula", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            TelaEscolhaCadastro telaEscolhaCadastro = new TelaEscolhaCadastro();
            telaEscolhaCadastro.Show();
        }

        private void linkMonitoramentoUsuarioLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gerenciamento.GerenciamentoUsuario gerenciamentoUsuario = new Gerenciamento.GerenciamentoUsuario();
            gerenciamentoUsuario.Show();
        }

        private void btnCadastrarBeneficiario_Click(object sender, EventArgs e)
        {
            CadastroBeneficiario cadastroBeneficiario = new CadastroBeneficiario();
            cadastroBeneficiario.Show();
        }

        private void btnCadastrarHospital_Click(object sender, EventArgs e)
        {
            CadastroHospital cadastroHospital = new CadastroHospital();
            cadastroHospital.Show();
        }

        private void MONITORAMENTO_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aFOSYDataSet1.BENEFICIARIOS'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'aFOSYDataSet.BENEFICIARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.bENEFICIARIOSTableAdapter.Fill(this.aFOSYDataSet.BENEFICIARIOS);

        }
    }
    
    
}
