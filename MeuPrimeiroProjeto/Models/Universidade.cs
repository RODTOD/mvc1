using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuPrimeiroProjeto.Models
{
    public class Universidade
    {
        public int UniversidadeID { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        //a propriedade eh virtual pois havera uma sobrescrita do método mais a frente
        public virtual ICollection<Curso> Curso { get; set; }
    }
}