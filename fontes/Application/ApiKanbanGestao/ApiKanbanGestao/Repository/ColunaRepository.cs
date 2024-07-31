using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;

namespace ApiKanbanGestao.Repository
{
    public class ColunaRepository : IColunaRepository
    {
        private readonly KanbanGestaoDbContext _kanbanGestaoDb;

        public ColunaRepository(KanbanGestaoDbContext kanbanGestaoDbContext)
        {
            _kanbanGestaoDb = kanbanGestaoDbContext;
        }
        public Task<ColunaDTO> AddColumn(ColunaXAtividade coluna)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteColumn(int idColuna)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaDTO> EditColumn(ColunaXAtividade coluna, int idColuna)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaDTO> GetAllColumnById(int idAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColunaDTO>> GetAllColumns()
        {
            throw new NotImplementedException();
        }
    }
}
