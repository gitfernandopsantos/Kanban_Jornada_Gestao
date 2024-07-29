using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IColunaRepository
    {
        Task<List<ColunaDTO>> GetAllColumns();
        Task<ColunaDTO> GetAllColumnById(int idAtividade);
        Task<ColunaDTO> AddColumn(Coluna coluna);
        Task<ColunaDTO> EditColumn(Coluna coluna, int idColuna);
        Task<bool> DeleteColumn(int idColuna);
    }
}
