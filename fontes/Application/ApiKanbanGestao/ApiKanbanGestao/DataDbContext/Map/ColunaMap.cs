using ApiKanbanGestao.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiKanbanGestao.DataDbContext.Map
{
    public class ColunaMap : IEntityTypeConfiguration<Coluna>
    {
        public void Configure(EntityTypeBuilder<Coluna> builder)
        {
            builder.ToTable("Colunas", "public");
            builder.HasKey(x => x.IdColuna);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
        }
    }
}
