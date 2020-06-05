using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEscola.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEscola.Repositorio.Mapping
{
    public class EscolaMapping : IEntityTypeConfiguration<Escola>
    {
        public void Configure(EntityTypeBuilder<Escola> builder)
        {
            builder.ToTable("escola");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
