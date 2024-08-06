using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ApiKanbanGestao.Repository
{
    public class ColunaXAtividadeRepository : IColunaXAtividadeRepository
    {
        private readonly KanbanGestaoDbContext _kanbanGestaoDb;

        public ColunaXAtividadeRepository(KanbanGestaoDbContext kanbanGestaoDbContext)
        {
            _kanbanGestaoDb = kanbanGestaoDbContext;
        }

        public async Task<ColunaXAtividade> AddColumnXActivity(ColunaXAtividadeDTO colunaXAtividadeDto)
        {
            try
            {
                var colunaXAtividadeEntity = new ColunaXAtividade(colunaXAtividadeDto.ColunaId, colunaXAtividadeDto.AtividadeId);

                var colunaXAtividadeAdicionada = await _kanbanGestaoDb.ColunasXAtividades.AddAsync(colunaXAtividadeEntity);

                if (colunaXAtividadeAdicionada == null || colunaXAtividadeAdicionada.Entity == null)
                {
                    throw new DbUpdateException("Não foi possível adicionar essa relação ao banco de dados.");
                }

                await _kanbanGestaoDb.SaveChangesAsync();

                return colunaXAtividadeAdicionada.Entity;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao adicionar a relação de coluna e atividade.", ex);
            }
        }

        public async Task<bool> DeleteColumnXActivity(int idColunaXAtividade)
        {
            try
            {
                var colunaXAtividadeExistente = await _kanbanGestaoDb.ColunasXAtividades.FindAsync(idColunaXAtividade);

                if (colunaXAtividadeExistente == null)
                {
                    throw new KeyNotFoundException("A relação de coluna e atividade especificada não foi encontrada.");
                }

                _kanbanGestaoDb.ColunasXAtividades.Remove(colunaXAtividadeExistente);
                await _kanbanGestaoDb.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao deletar a relação de coluna e atividade.", ex);
            }
        }

        public async Task<ColunaXAtividade> UpdateColumnXActivity(ColunaXAtividadeDTO colunaXAtividadeDto, int idColunaXAtividade)
        {
            try
            {
                var colunaXAtividadeExistente = await _kanbanGestaoDb.ColunasXAtividades.FindAsync(idColunaXAtividade);

                if (colunaXAtividadeExistente == null)
                {
                    throw new KeyNotFoundException("A relação de coluna e atividade especificada não foi encontrada.");
                }

                _kanbanGestaoDb.Entry(colunaXAtividadeExistente).CurrentValues.SetValues(colunaXAtividadeDto);
                await _kanbanGestaoDb.SaveChangesAsync();

                return colunaXAtividadeExistente;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar a relação de coluna e atividade.", ex);
            }
        }

        public async Task<List<ColunaXAtividade>> GetAllColumnsXActivity()
        {
            try
            {
                var query = await _kanbanGestaoDb.ColunasXAtividades
                 .Include(cxa => cxa.Coluna)
                 .Include(cxa => cxa.Atividade)
                 .ToListAsync();
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ColunaXAtividade> GetAllColumnXActivityById(int idColunaXAtividade)
        {
            try
            {
                var query = await _kanbanGestaoDb.ColunasXAtividades
                    .Include(cxa => cxa.Coluna)
                    .Include(cxa => cxa.Atividade)
                    .FirstOrDefaultAsync(cxa => cxa.IdColunaXAtividade == idColunaXAtividade);
                return query;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
