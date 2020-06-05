using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjetoEscola.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEscola.Repositorio.Contexto
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() { }

        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options) { }


        public DbSet<Escola> Escola { get; set; }
        public DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EscolaContext).Assembly);

            //modelBuilder.Entity<Turma>()
            //                   .HasOne(x => x.Escola)
            //                   .WithMany(u => u.Turmas)
            //                   .HasForeignKey(x => x.EscolaId);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationBuilder();
            //builder.AddJsonFile("appsettings.json", optional: false);
            //var configuration = builder.Build();

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9MI2HLT;Initial Catalog=Escola;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");

        }
    }
}
