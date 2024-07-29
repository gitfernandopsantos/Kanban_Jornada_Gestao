using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;

namespace ApiKanbanGestao.Repository
{
    public class ColunaXAtividadeRepository : IColunaXAtividadeRepository
    {
        public Task<ColunaXAtividadeDTO> AddColumnXActivity(ColunaXAtividade colunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteColumnXActivity(int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaXAtividadeDTO> EditColumnXActivity(ColunaXAtividade colunaXAtividade, int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColunaXAtividadeDTO>> GetAllColumnsXActivity()
        {
            throw new NotImplementedException();
        }

        public Task<ColunaXAtividadeDTO> GetAllColumnXActivityById(int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }
    }
}
