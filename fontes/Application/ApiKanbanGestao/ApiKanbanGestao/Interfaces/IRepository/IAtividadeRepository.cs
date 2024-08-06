using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IAtividadeRepository
    {
        
        Task<List<Atividade>> GetAllActivity();
        Task<Atividade> GetAllActivityById(int idAtividade);
        Task<Atividade> AddActivity(AtividadeDTO atividade);
        Task<Atividade> UpdateActivity(AtividadeDTO atividade, int idAtividade);
        Task<bool> DeleteActivity(int idAtividade);
    }
}
