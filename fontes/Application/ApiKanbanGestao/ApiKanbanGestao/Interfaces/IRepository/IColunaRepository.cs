using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IColunaRepository
    {
        Task<List<Coluna>> GetAllColumns();
        Task<Coluna> GetAllColumnById(int idColuna);
        Task<Coluna> AddColumn(ColunaDTO coluna);
        Task<Coluna> UpdateColumn(ColunaDTO coluna, int idColuna);
        Task<bool> DeleteColumn(int idColuna);
    }
}
