using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IAtividadeRepository
    {
        
        Task<List<Atividade>> GetAllActivity();
        Task<Atividade> GetAllActivityById(int idAtividade);
        Task<Atividade> AddActivity(Atividade atividade);
        Task<Atividade> UpdateActivity(Atividade atividade, int idAtividade);
        Task<bool> DeleteActivity(int idAtividade);
    }
}
