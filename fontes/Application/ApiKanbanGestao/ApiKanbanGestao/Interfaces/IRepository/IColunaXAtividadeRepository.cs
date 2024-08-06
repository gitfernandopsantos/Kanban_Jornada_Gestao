using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IColunaXAtividadeRepository
    {
        Task<List<ColunaXAtividade>> GetAllColumnsXActivity();
        Task<ColunaXAtividade> GetAllColumnXActivityById(int idColunaXAtividade);
        Task<ColunaXAtividade> AddColumnXActivity(ColunaXAtividadeDTO colunaXAtividade);
        Task<ColunaXAtividade> UpdateColumnXActivity(ColunaXAtividadeDTO colunaXAtividade, int idColunaXAtividade);
        Task<bool> DeleteColumnXActivity(int idColunaXAtividade);
    }
}
