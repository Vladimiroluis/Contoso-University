using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class DadosEscolares : DbContext
    {
        public DadosEscolares() : base("DadosEscolares")
        {
        }

        public DbSet<Estudante> Estudante { get; set; }
        public DbSet<Inscricao> Inscricao { get; set; }
        public DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}