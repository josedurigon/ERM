using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afosy.Classes
{
    public class Usuario
    {
       

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento  { get; set; }

        public string Sexo { get; set; }

        public string Contato { get; set; }

        public string Email { get; set; }

        public string ConfirmacaoEmail { get; set; }

        public string RegistroProfissional { get; set; }

        public string UploadFoto { get; set; }

       
        

        /*
        public Usuario(string nome, string sobrenome, DateTime dataNascimento, string sexo, string contato, string email, string confirmacaoEmail, string registroProfissional, string uploadFoto)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Contato = contato;
            this.Email = email;
            this.ConfirmacaoEmail = confirmacaoEmail;
            this.RegistroProfissional = registroProfissional;
            this.UploadFoto = uploadFoto;
        }
        */


    }
}
