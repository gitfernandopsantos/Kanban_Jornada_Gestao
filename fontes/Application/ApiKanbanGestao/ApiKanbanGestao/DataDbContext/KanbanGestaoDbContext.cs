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
        public DbSet<Coluna> Coluna { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<ColunaXAtividade> ColunaXAtividade { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
