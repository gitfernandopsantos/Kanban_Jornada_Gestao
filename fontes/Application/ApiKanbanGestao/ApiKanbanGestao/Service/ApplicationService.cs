using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IService;

namespace ApiKanbanGestao.Service
{
    public class ApplicationService : IApplicationService
    {
        public Task<AtividadeDTO> AddActivity(Atividade atividade)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaDTO> AddColumn(Coluna coluna)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaXAtividadeDTO> AddColumnXActivity(ColunaXAtividade colunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteActivity(int idAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteColumn(int idColuna)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteColumnXActivity(int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<AtividadeDTO> EditActivity(Atividade atividade, int idAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaDTO> EditColumn(Coluna coluna, int idColuna)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaXAtividadeDTO> EditColumnXActivity(ColunaXAtividade colunaXAtividade, int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<List<AtividadeDTO>> GetAllActivity()
        {
            throw new NotImplementedException();
        }

        public Task<AtividadeDTO> GetAllActivityById(int idAtividade)
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
