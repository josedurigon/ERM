using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afosy.Classes
{
    public class Beneficiario
    {

        public int CodigoBeneficiario { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int IdadeProcessada { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DataInternacao { get; set; }

        public DateTime DataAlta { get; set; }

        public DateTime TempoPermanenciaHospitalar { get; set; }

        public string QuadroClinico { get; set; }

        public string Reinternacao { get; set; }

        public string CID { get; set; }

       

        /*
        public Beneficiario(string nome, string sobrenome, int idadeProcessada,
          DateTime dataInclusao, DateTime dataInternacao, DateTime dataAlta,
          int numeroBeneficiario, DateTime tempoPermanenciaHospitalar,
          string quadroClinico, string reinternacao)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.IdadeProcessada = idadeProcessada;
            this.DataInclusao = dataInclusao;
            this.DataInternacao = dataInternacao;
            this.DataAlta = dataAlta;
            this.CodigoBeneficiario = numeroBeneficiario;
            this.TempoPermanenciaHospitalar = tempoPermanenciaHospitalar;
            this.QuadroClinico = quadroClinico;
            this.Reinternacao = reinternacao;
        }
        */




    }
}
