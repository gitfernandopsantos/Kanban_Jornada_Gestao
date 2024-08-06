using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ApiKanbanGestao.Repository
{
    public class ColunaRepository : IColunaRepository
    {
        private readonly KanbanGestaoDbContext _kanbanGestaoDb;

        public ColunaRepository(KanbanGestaoDbContext kanbanGestaoDbContext)
        {
            _kanbanGestaoDb = kanbanGestaoDbContext;
        }

        public async Task<Coluna> AddColumn(ColunaDTO coluna)
        {
            try
            {
                var colunaEntity = new Coluna(coluna.Nome);

                var colunaAdicionada = await _kanbanGestaoDb.Colunas.AddAsync(colunaEntity);

                if (colunaAdicionada == null || colunaAdicionada.Entity == null)
                {
                    throw new DbUpdateException("Não foi possível adicionar essa coluna ao banco de dados.");
                }

                await _kanbanGestaoDb.SaveChangesAsync();

                return colunaAdicionada.Entity;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao adicionar a coluna.", ex);
            }
        }

        public async Task<bool> DeleteColumn(int idColuna)
        {
            try
            {
                var colunaExistente = await _kanbanGestaoDb.Colunas.FindAsync(idColuna);

                if (colunaExistente == null)
                {
                    throw new KeyNotFoundException("A coluna especificada não foi encontrada.");
                }

                _kanbanGestaoDb.Colunas.Remove(colunaExistente);
                await _kanbanGestaoDb.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao deletar a coluna.", ex);
            }
        }

        public async Task<Coluna> GetAllColumnById(int idColuna)
        {
            try
            {
                var query = await _kanbanGestaoDb.Colunas.FindAsync(idColuna);
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Coluna>> GetAllColumns()
        {
            try
            {
                var query = await _kanbanGestaoDb.Colunas.ToListAsync();
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Coluna> UpdateColumn(ColunaDTO coluna, int idColuna)
        {
            try
            {
                var colunaExistente = await _kanbanGestaoDb.Colunas.FindAsync(idColuna);

                if (colunaExistente == null)
                {
                    throw new KeyNotFoundException("A coluna especificada não foi encontrada.");
                }

                _kanbanGestaoDb.Entry(colunaExistente).CurrentValues.SetValues(coluna);
                await _kanbanGestaoDb.SaveChangesAsync();

                return colunaExistente;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar a coluna.", ex);
            }
        }
    }
}
