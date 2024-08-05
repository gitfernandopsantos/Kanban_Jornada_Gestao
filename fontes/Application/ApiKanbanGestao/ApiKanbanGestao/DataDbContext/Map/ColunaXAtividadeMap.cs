using ApiKanbanGestao.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiKanbanGestao.DataDbContext.Map
{
    public class ColunaXAtividadeMap : IEntityTypeConfiguration<ColunaXAtividade>
    {
        public void Configure(EntityTypeBuilder<ColunaXAtividade> builder)
        {
            builder.ToTable("ColunasXAtividades", "public");
            builder.HasKey(x => x.IdColunaXAtividade);
            builder.Property(x => x.AtividadeId).IsRequired();
            builder.Property(x => x.ColunaId).IsRequired();
            builder.HasOne(x => x.Coluna);
            builder.Property(x => x.AtividadeId).IsRequired();
            builder.HasOne(x => x.Atividade);
        }
    }
}
