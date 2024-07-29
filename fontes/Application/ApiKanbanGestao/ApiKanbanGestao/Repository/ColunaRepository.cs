using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;

namespace ApiKanbanGestao.Repository
{
    public class ColunaRepository : IColunaRepository
    {
        public Task<ColunaDTO> AddColumn(Coluna coluna)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteColumn(int idColuna)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaDTO> EditColumn(Coluna coluna, int idColuna)
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
