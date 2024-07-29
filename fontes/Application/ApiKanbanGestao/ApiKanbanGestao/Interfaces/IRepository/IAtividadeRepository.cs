using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IAtividadeRepository
    {
        Task<List<AtividadeDTO>> GetAllActivity();
        Task<AtividadeDTO> GetAllActivityById(int idAtividade);
        Task<AtividadeDTO> AddActivity(Atividade atividade);
        Task<AtividadeDTO> EditActivity(Atividade atividade, int idAtividade);
        Task<bool> DeleteActivity(int idAtividade);
    }
}
