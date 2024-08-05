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
        public async Task<Atividade> AddActivity(Atividade atividade)
        {
            try
            {
                var atividadeAdicionada = _kanbanGestaoDb.Add(atividade);

                if (atividadeAdicionada == null || atividadeAdicionada.Entity == null)
                {
                    throw new DbUpdateException("Não foi possível adicionar essa atividade ao banco de dados.");
                }

                await _kanbanGestaoDb.SaveChangesAsync();
                return atividadeAdicionada.Entity;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao adicionar a atividade.", ex);
            }
        }


        public Task<bool> DeleteActivity(int idAtividade)
        {
            throw new NotImplementedException();
        }

        public async Task<Atividade> UpdateActivity(Atividade atividade, int idAtividade)
        {
            try
            {
                var atividadeExistente = await _kanbanGestaoDb.Atividades.FindAsync(idAtividade);

                if (atividadeExistente == null)
                {
                    throw new KeyNotFoundException("A atividade especificada não foi encontrada.");
                }

                _kanbanGestaoDb.Entry(atividadeExistente).CurrentValues.SetValues(atividade);
                await _kanbanGestaoDb.SaveChangesAsync();

                return atividadeExistente;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar a atividade.", ex);
            }
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
