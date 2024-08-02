using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ApiKanbanGestao.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly KanbanGestaoDbContext _kanbanGestaoDb;
        public AtividadeRepository(KanbanGestaoDbContext kanbanGestaoDbContext)
        {
            _kanbanGestaoDb = kanbanGestaoDbContext;
        }
        public Task<Atividade> AddActivity(Atividade atividade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteActivity(int idAtividade)
        {
            throw new NotImplementedException();
        }

        public async Task<AtividadeDTO> EditActivity(Atividade atividade, int idAtividade)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Atividade>> GetAllActivity()
        {
            try
            {
                var query = await _kanbanGestaoDb.Atividades.ToListAsync();
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Atividade> GetAllActivityById(int idAtividade)
        {
            try
            {
                var query = await _kanbanGestaoDb.Atividades.FindAsync(idAtividade);
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
