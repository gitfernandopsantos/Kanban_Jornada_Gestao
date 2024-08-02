using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IService
{
    public interface IApplicationService
    {
        #region Métodos Atividades
        Task<List<Atividade>> GetAllActivity();
        Task<Atividade> GetAllActivityById(int idAtividade);
        Task<Atividade> AddActivity(Atividade atividade);
        Task<AtividadeDTO> EditActivity(Atividade atividade, int idAtividade);
        Task<bool> DeleteActivity(int idAtividade);
        #endregion

        #region Métodos Colunas
        Task<List<ColunaDTO>> GetAllColumns();
        Task<ColunaDTO> GetAllColumnById(int idAtividade);
        Task<ColunaDTO> AddColumn(ColunaXAtividade coluna);
        Task<ColunaDTO> EditColumn(ColunaXAtividade coluna, int idColuna);
        Task<bool> DeleteColumn(int idColuna);
        #endregion

        #region Métodos Colunas X Atividades
        Task<List<ColunaXAtividadeDTO>> GetAllColumnsXActivity();
        Task<ColunaXAtividadeDTO> GetAllColumnXActivityById(int idColunaXAtividade);
        Task<ColunaXAtividadeDTO> AddColumnXActivity(ColunaXAtividade colunaXAtividade);
        Task<ColunaXAtividadeDTO> EditColumnXActivity(ColunaXAtividade colunaXAtividade, int idColunaXAtividade);
        Task<bool> DeleteColumnXActivity(int idColunaXAtividade);
        #endregion
    }
}
