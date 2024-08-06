using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IService
{
    public interface IApplicationService
    {
        #region Métodos Atividades
        Task<List<Atividade>> GetAllActivity();
        Task<Atividade> GetAllActivityById(int idAtividade);
        Task<Atividade> AddActivity(AtividadeDTO atividade);
        Task<Atividade> UpdateActivity(AtividadeDTO atividade, int idAtividade);
        Task<bool> DeleteActivity(int idAtividade);
        #endregion

        #region Métodos Colunas
        Task<List<Coluna>> GetAllColumns();
        Task<Coluna> GetColumnById(int idAtividade);
        Task<Coluna> AddColumn(ColunaDTO coluna);
        Task<Coluna> UpdateColumn(ColunaDTO coluna, int idColuna);
        Task<bool> DeleteColumn(int idColuna);
        #endregion

        #region Métodos Colunas X Atividades
        Task<List<ColunaXAtividade>> GetAllColumnsXActivity();
        Task<ColunaXAtividade> GetColunaXAtividadeById(int idColunaXAtividade);
        Task<ColunaXAtividade> AddColumnXActivity(ColunaXAtividadeDTO colunaXAtividade);
        Task<ColunaXAtividade> UpdateColumnXActivity(ColunaXAtividadeDTO colunaXAtividade, int idColunaXAtividade);
        Task<bool> DeleteColumnXActivity(int idColunaXAtividade);
        #endregion
    }
}
