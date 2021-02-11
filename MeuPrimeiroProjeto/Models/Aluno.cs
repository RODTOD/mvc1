﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroProjeto.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }

        public int CursoID { get; set; }

        [ForeignKey("CursoID")]

        public virtual Curso Curso { get; set; }

    }
}