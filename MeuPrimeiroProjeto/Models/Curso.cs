using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroProjeto.Models
{
    public class Curso
    {
        public int CursoID { get; set; }

        public string Nome { get; set; }
        
        public int UniversidadeID { get; set; }

        [ForeignKey("UniversidadeID")]

        public virtual Universidade Universidade { get; set; }
    }
}