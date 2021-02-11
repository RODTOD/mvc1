using MeuPrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MeuPrimeiroProjeto.DAO
{
    public class EFContext : DbContext
    {
        //palavra base é usada para referenciar membros de classes extendidas
        public EFContext() : base("EFConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//para nao converter as classes para o plural
            base.OnModelCreating(modelBuilder);

        }


        public DbSet<Universidade> Universidades { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }




    }
}