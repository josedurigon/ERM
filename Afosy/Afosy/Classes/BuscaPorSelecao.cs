using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Afosy.Classes
{
    public class BuscaPorSelecao
    {
        public static string[] Itens = { "CODIGO", "NOME", "SOBRENOME", "IDADE", 
                                "DATA DE INCLUSÃO", "DATA DE INTERNAÇÃO", "DATA DE ALTA", 
                                "TEMPO DE PERMANCENCIA", "REINTERNAÇÃO","CID","QUADRO CLÍNICO" };


        public static string[] Procedures = {
            "dbo.spBENEFICIARIOS_PEGARTODOSPELOCODIGO",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELONOME",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELOSOBRENOME",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELAIDADE",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELADATAINCLUSAO",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELADATAINTERNACAO",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELADATADEALTA",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELOTEMPODEPERMANENCIA",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELAREINTERNACAO",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELOCID",
            "dbo.spBENEFICIARIOS_PEGARTUDOPELOQUADROCLINICO"
                                                    };
        //listar aqui todas as procedures criadas que vao correspnder ao indice do array acima! Precisam estar no mesmo indice!!!!


		
	}
}

