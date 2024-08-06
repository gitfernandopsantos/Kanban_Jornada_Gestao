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
        public async Task<Atividade> AddActivity(AtividadeDTO atividadeDto)
        {
            try
            {
                var atividadeEntity = new Atividade(atividadeDto.Nome, atividadeDto.Descricao, atividadeDto.DataCriacao, atividadeDto.DataInicio, atividadeDto.DataFim);

                var atividadeAdicionada = await _kanbanGestaoDb.AddAsync(atividadeEntity);

                if (atividadeAdicionada == null || atividadeAdicionada.Entity == null)
                {
                    throw new DbUpdateException("Não foi possível adicionar essa atividade ao banco de dados.");
                }

                _kanbanGestaoDb.SaveChanges();

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

        public async Task<bool> DeleteActivity(int idAtividade)
        {
            try
            {
                var atividadeExistente = await _kanbanGestaoDb.Atividades.FindAsync(idAtividade);

                if (atividadeExistente == null)
                {
                    throw new KeyNotFoundException("A atividade especificada não foi encontrada.");
                }

                var atividadeDeletado = _kanbanGestaoDb.Atividades.Remove(atividadeExistente);
                await _kanbanGestaoDb.SaveChangesAsync();
                if (atividadeDeletado.Entity != null) 
                {
                    return true;
                }
                return false;
            }
            catch (DbUpdateException dbEx)
            {
                throw new DbUpdateException("Erro ao atualizar o banco de dados.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao deletar a atividade.", ex);
            }
        }


        public async Task<Atividade> UpdateActivity(AtividadeDTO atividadeDto, int idAtividade)
        {
            try
            {
                var atividadeExistente = await _kanbanGestaoDb.Atividades.FindAsync(idAtividade);

                if (atividadeExistente == null)
                {
                    throw new KeyNotFoundException("A atividade especificada não foi encontrada.");
                }

                _kanbanGestaoDb.Entry(atividadeExistente).CurrentValues.SetValues(atividadeDto);
                await _kanbanGestaoDb.SaveChangesAsync();
                var atividade = new Atividade(atividadeDto.Nome, atividadeDto.Descricao, atividadeDto.DataCriacao, atividadeDto.DataInicio, atividadeDto.DataFim);
                atividade.IdAtividade = idAtividade;
                return atividade;
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
