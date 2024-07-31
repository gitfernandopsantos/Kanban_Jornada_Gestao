using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Interfaces.IRepository
{
    public interface IColunaRepository
    {
        Task<List<ColunaDTO>> GetAllColumns();
        Task<ColunaDTO> GetAllColumnById(int idAtividade);
        Task<ColunaDTO> AddColumn(ColunaXAtividade coluna);
        Task<ColunaDTO> EditColumn(ColunaXAtividade coluna, int idColuna);
        Task<bool> DeleteColumn(int idColuna);
    }
}
