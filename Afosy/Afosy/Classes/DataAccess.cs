using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.File;

namespace Afosy.Classes
{
    class DataAccess
    {
        //Aqui é onde vai fazer a comunicação com o banco de dados
        public List<Usuario> GetUsuarios()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB")))
                {
                    connection.Open();
                    var output = connection.Query<Usuario>($"select * from USUARIOS ").ToList();
                    return output;
                }//conexao morre aqui
            }


            catch (Exception)
            {/// Isso aqui é um logger que escreve a situação da exceção do evento e disponibiliza num arquivo .txt
                string evento = "A conexão com o banco de dados noi foi realizada com sucesso\n. " +
                    "Evento localizado na linha 21 {classe: DataAccess}. Verificar as credenciais do banco de dados.";
                Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("log-.txt",LogEventLevel.Error, outputTemplate:"{Timestamp:dd/mm/yyyy HH:mm:ss.fff zzz} [{Level:u3}] [message:lj}{NewLine}{Exemption}",
                    rollingInterval: RollingInterval.Hour)
                    .CreateLogger();
                Log.Information(evento);
                    
                
                return null;
            }
        }

        public List<Beneficiario> GetBeneficiarios()
        {
            try
            {
                using(IDbConnection connection = new SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB")))
                {
                    connection.Open();
                    
                    string selecionarbeneficiarios = "dbo.spBENEFICIARIOS_PEGARTODOS"; 

                    //Utilizando o sql adapter pra ver se da certo fazer o bind com o datagridview no monitoramento
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from USUARIOS", connection.ToString());
                    DataSet dataset = new DataSet();
                    var output2 = adapter.Fill(dataset);
                    //ate aqui a mudança


                    var output = connection.Query<Beneficiario>(selecionarbeneficiarios,param:null, commandType: CommandType.StoredProcedure).ToList();
                    return output.ToList();
                    
                }//conexão morreu

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Algo deu errado...{ex}");//Pra essa bagaça rodar a sua classe que vai servir de molde NAO PODE TER CONSTRUTORES!!!     
                
                return null;
            }
        }



        public void InsertUsuario(string nome, string sobrenome, DateTime dataNascimento, string sexo, string contato,
                                    string email, string confirmacaoEmail, string registroProfissional, string uploadFoto)
            
        {

            try
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB")))
                {
                    connection.Open();
                    List<Usuario> usuario = new List<Usuario>();
                    usuario.Add(new Usuario
                    {
                        Nome = nome,
                        Sobrenome = sobrenome,
                        DataNascimento = dataNascimento,
                        Sexo = sexo,
                        Contato = contato,
                        Email = email,
                        ConfirmacaoEmail = confirmacaoEmail,
                        RegistroProfissional = registroProfissional,
                        UploadFoto = uploadFoto
                    });

                    
                    connection.Execute("" +
                        "INSERT INTO [AFOSY] [dbo].[USUARIOS] VALUES()");
                }//conexão morreu
            }
            catch (Exception)
            {

            }

        }
    }
}

///Sintaxe do "command":  
///string insertQuery = @"INSERT INTO [dbo].[Customer]([FirstName], [LastName], [State], [City], 
///[IsActive], [CreatedOn]) VALUES (@FirstName, @LastName, @State, @City, @IsActive, @CreatedOn)";


//Isso aqui voce vai utilizar SEMPRE que for conectar com o Banco de dados. Copie e cole onde vc for usar.
//Lembre-se sempre de fechar conexoes abertas.

/*
  
using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConexaoBancoDados.CnnVal("AFOSYDB"))
{

}

*/