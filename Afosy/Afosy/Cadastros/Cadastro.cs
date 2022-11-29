using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FluentValidation;
using FluentValidation.Validators;
using Serilog;
using Serilog.Sinks;
using Serilog.Core;
using Serilog.Events;
using Afosy.Classes;
using System.Threading;

namespace Afosy
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }


        

       

        private void button3_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg Files(*.jpg)|*.jpg|PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK) { ImageLocation = dialog.FileName; }
                pictureBox1.ImageLocation = ImageLocation;
            }
            catch (Exception ex)
            {
                //listar o erro
                MessageBox.Show($"Ocorreu um erro ao tentar carregar a imagem\n Descrição do erro:{ex} ");
                

            }
        }

        private void txtbxNome_TextChanged(object sender, EventArgs e)
        {
           errorProvider1.Clear();
        }       

        private void txtbxSobrenome_TextChanged(object sender, EventArgs e)
        {
            
            
           errorProvider1.Clear();
            
        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {
            if(txtBxEmailUsuarios.Text.Length == 0)
            {
                errorProvider1.SetError(txtBxEmailUsuarios, "Por favor, insira um email");
                
            }
        }

        private void txtbxConfirmarEmail_TextChanged(object sender, EventArgs e)
        {/*
            if ( txtbxEmail!= txtbxConfirmarEmail)
            {
                errorProvider1.SetError(txtbxConfirmarEmail, "O endereço de email não conicide com o informado.");
                Update();
            }
            else
            {
                Update();
            }*/
        }

        private void txtbxConfirmarEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txTbxConfirmarEmailUsuarios != txtBxEmailUsuarios)
            {
                errorProvider1.SetError(txTbxConfirmarEmailUsuarios, "O endereço nao coincide com o informado");
                Update(); //vamos ver se funciona
            }
        }

        private void btnSalvarCadastroUsuarios_Click(object sender, EventArgs e)
        {
            //checar se as condições de preenchimento foram atendidas aqui------
            //depois so colocar um errorprovider1.Clear();
            string nomeinput = txtbxNomeUsuarios.Text;
            if(string.IsNullOrWhiteSpace(nomeinput))
            {
                errorProvider1.SetError(txtbxNomeUsuarios, "Nome obrigatório");
            }
            else if (nomeinput.All(char.IsDigit) || nomeinput.Any(char.IsDigit))
            {
                errorProvider1.SetError(txtbxNomeUsuarios, "Apenas caracteres devem ser inseridos");
            }
            string sobrenomeinput = txtbxSobrenomeUsuarios.Text;
            if (string.IsNullOrWhiteSpace(sobrenomeinput))
            {
                errorProvider1.SetError(txtbxSobrenomeUsuarios, "Sobrenome obrigatório");
            }
            else if(sobrenomeinput.All(char.IsDigit) || sobrenomeinput.Any(char.IsDigit))
            {
                errorProvider1.SetError(txtbxSobrenomeUsuarios, "Apenas caracteres devem ser inseridos");
            }


        }

        private void maskedTxtBoxNascimentoUsuarios_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            errorProvider1.SetError(maskedTxtBoxNascimentoUsuarios, "Formato da data: DD - MM - AAAA (dia - mes - ano)");
          
        }

        private void maskedTxtBoxNascimentoUsuarios_MaskChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
