using ApiKanbanGestao.DataDbContext.Map;
using ApiKanbanGestao.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApiKanbanGestao.DataDbContext
{
    public class KanbanGestaoDbContext : DbContext
    {
        public KanbanGestaoDbContext()
        {
            
        }
        public KanbanGestaoDbContext(DbContextOptions<KanbanGestaoDbContext> options) : base(options)
        {
            
        }
        public DbSet<Coluna> Colunas { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<ColunaXAtividade> ColunasXAtividades { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.ApplyConfiguration(new AtividadeMap());
            modelBuilder.ApplyConfiguration(new ColunaMap());
            modelBuilder.ApplyConfiguration(new ColunaXAtividadeMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
