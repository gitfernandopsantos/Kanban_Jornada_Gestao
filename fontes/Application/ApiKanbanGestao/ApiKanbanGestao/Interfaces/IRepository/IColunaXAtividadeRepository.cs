using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IColunaXAtividadeRepository
    {
        Task<List<ColunaXAtividadeDTO>> GetAllColumnsXActivity();
        Task<ColunaXAtividadeDTO> GetAllColumnXActivityById(int idColunaXAtividade);
        Task<ColunaXAtividadeDTO> AddColumnXActivity(ColunaXAtividade colunaXAtividade);
        Task<ColunaXAtividadeDTO> EditColumnXActivity(ColunaXAtividade colunaXAtividade, int idColunaXAtividade);
        Task<bool> DeleteColumnXActivity(int idColunaXAtividade);
    }
}
