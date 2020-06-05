using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEscola.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEscola.Repositorio.Mapping
{
    public class TurmaMapping : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("turma");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(x => x.Vagas)
                .HasColumnName("vagas")
                .IsRequired();

            builder.HasOne(t => t.Escola)
            .WithMany(e => e.Turmas)
            .HasForeignKey(t => t.EscolaId);

        }
    }
}
