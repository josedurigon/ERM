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

namespace Afosy.Cadastros
{
    public partial class CadastroBeneficiario : Form
    {
        public CadastroBeneficiario()
        {
            InitializeComponent();
        }

        private void btnSalvarCadastroBeneficiario_Click(object sender, EventArgs e)
        {
            string dataalta = "";
            string datainclusao = "";
            string datainternacao = "";
            string reinternacao = "";
            if (radioButtonReinternacaoNao.Checked)
            {
                reinternacao = "Nao";   
            }
            else
            {
                reinternacao = "Sim";
            }

            string nomeBeneficiario = txtBoxNomeBeneficiario.Text;
            string sobrenomeBeneficiario = txtBoxSobrenomeBeneficiario.Text;
            string dataNascimento = maskedTxtBoxNascimentoBeneficiario.Text;
            int idade = Convert.ToInt16(txtBoxIdadeBeneficiario.Text);
            datainclusao = maskedtTxtBoxDataInclusaoBeneficiario.Text;
            datainternacao = maskedTxtBoxDataInternacao.Text;
            dataalta = maskedTxtBoxDataAltaBeneficiario.Text;
            string cid = txtBoxCidBeneficiario.Text;
            string quadroClinico = txtBoxQuadroClinicoBeneficiario.Text;

            //-----------------------conversões de data aqui---------------------------------------------
            //data de inclusão---
            /*
            string diaDataInclusao = datainclusao.Substring(0, 2);
            string mesDatainclusao = datainclusao.Substring(3, 2);             
            string anoDataInlcusao = datainclusao.Substring(6, 4);
            int diaInclusao = Convert.ToInt16(anoDataInlcusao);
            int mesInclusao = Convert.ToInt16(mesDatainclusao);
            int anoInclusao = Convert.ToInt16(diaDataInclusao);

            //data de internação
            string diaDataInternacao = datainternacao.Substring(0, 2);
            string mesDataInternacao = datainternacao.Substring(3, 2);
            string anoDataInternacao = datainternacao.Substring(6, 4);
            int diaInternacao = Convert.ToInt16(diaDataInternacao);
            int mesInternacao = Convert.ToInt16(mesDataInternacao);
            int anoInternacao = Convert.ToInt16(anoDataInternacao);

            //data de alta
            string diaDataAlta= dataalta.Substring(0, 2);
            string mesDataAlta = dataalta.Substring(3, 2);
            string anoDataAlta = dataalta.Substring(6, 4);
            int diaAlta = Convert.ToInt16(diaDataAlta);
            int mesAlta = Convert.ToInt16(mesDataAlta);
            int anoAlta = Convert.ToInt16(anoDataAlta);
            */
            //----------------------------------Finito--------------------------------------------------
            /*
            if(mesAlta == 01 || mesAlta == 03 || mesAlta == 05 || mesAlta == 07 || mesAlta == 09 || mesAlta == 12)
            {
                
                //mes tem 31 dias
            }
            else if(mesAlta == 04 || mesAlta==06 || mesAlta == 09 || mesAlta == 11)
            {
                //mes possui 30 dias
            }
            else
            {
                //fevereiro com 28 dias
            }
            */
            //se data internação for 20/05/2022
            //se data de alta for 29/10/2022
            // para contar a quantidade de dias tem que fazer: diferença da quantidade de meses *5 meses, multiplicado pelo total de dias do mes

            int tempopermanencia = Convert.ToInt16(txtBoxTempoPermanencia.Text);
            
            

            using(SqlConnection cn = new SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB")))
            {
                cn.Open();
                string comando = $"INSERT INTO BENEFICIARIOS VALUES (CAST((RAND() * (899999) + 100000) as int)," +
                    $"'{nomeBeneficiario}','{sobrenomeBeneficiario}',{idade}, '{datainclusao}'," +
                    $"'{datainternacao}','{dataalta}',{tempopermanencia},'{quadroClinico}','{reinternacao}','{cid}')";

                cn.Execute(comando);
            }
        }

        private void radioButtonReinternacaoSim_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

            /*	(CAST((RAND() * (899999) + 100000) as int),'MARIA','ALGARVE',45,'2022-05-06','2022-05-08',SYSDATETIME(),
             *	DATEDIFF(DAY,'2022-05-06',SYSDATETIME()),'QUEIXA DE DOR NA PERNA','NAO','NULO');
              */