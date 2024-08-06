using ApiKanbanGestao.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiKanbanGestao.DataDbContext.Map
{
    public class AtividadeMap : IEntityTypeConfiguration<Atividade>
    {
        public void Configure(EntityTypeBuilder<Atividade> builder)
        {
            builder.ToTable("Atividades", "public");
            builder.HasKey(x => x.IdAtividade);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Descricao).HasMaxLength(1000);
            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.DataInicio);
            builder.Property(x => x.DataFim);
        }
    }
}
