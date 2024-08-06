using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;
using ApiKanbanGestao.Interfaces.IService;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ApiKanbanGestao.Service
{
    public class ApplicationService : IApplicationService
    {
        private readonly IAtividadeRepository _atividadeRepository;
        private readonly IColunaRepository _colunaRepository;
        private readonly IColunaXAtividadeRepository _colunaXAtividadeRepository;
        public ApplicationService(IAtividadeRepository atividadeRepository, IColunaRepository colunaRepository, IColunaXAtividadeRepository colunaXAtividadeRepository)
        {
            _atividadeRepository = atividadeRepository;
            _colunaRepository = colunaRepository;
            _colunaXAtividadeRepository = colunaXAtividadeRepository;
        }

        #region Activity
        public Task<Atividade> AddActivity(AtividadeDTO atividade)
        {
            try
            {
                if (_atividadeRepository == null)
                {
                    throw new InvalidOperationException("Repositório de atividades não está inicializado.");
                }
                var atividadeAdicionada = _atividadeRepository.AddActivity(atividade);
                return atividadeAdicionada;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public Task<Atividade> UpdateActivity(AtividadeDTO atividade, int idAtividade)
        {
            try
            {
                if (_atividadeRepository == null)
                {
                    throw new InvalidOperationException("Repositório de atividades não está inicializado.");
                }

                var atividadeAtualizada = _atividadeRepository.UpdateActivity(atividade, idAtividade);
                return atividadeAtualizada;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }


        public Task<bool> DeleteActivity(int idAtividade)
        {
            try
            {
                if (_atividadeRepository == null)
                {
                    throw new InvalidOperationException("Repositório de atividades não está inicializado.");
                }
                Task<bool> valorDaAtividadeDeletado = _atividadeRepository.DeleteActivity(idAtividade);
                return valorDaAtividadeDeletado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<List<Atividade>> GetAllActivity()
        {
            try
            {
                if (_atividadeRepository != null)
                {
                    var listActivity = _atividadeRepository.GetAllActivity();
                    if (listActivity != null)
                    {
                        return listActivity;
                    }
                    else
                    {
                        throw new Exception("Nenhuma atividade encontrada no banco de dados.");
                    }
                }
                throw new Exception("Não foi possível encontrar o repositório.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Task<Atividade> GetAllActivityById(int idAtividade)
        {
            try
            {
                if (_atividadeRepository != null)
                {
                    if (idAtividade <= 0)
                    {
                        throw new Exception("Por favor, insira um ID válido.");
                    }
                    var activity = _atividadeRepository.GetAllActivityById(idAtividade);
                    if (activity.Result == null && activity.IsCompletedSuccessfully == true)
                    {
                        throw new Exception("Desculpe, não encontramos essa atividade no banco de dados.");
                    }
                    return activity;
                }
                throw new Exception("Não foi possível encontrar o repositório");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion


        #region Methods Column
        public async Task<Coluna> AddColumn(ColunaDTO coluna)
        {
            try
            {
                if (_colunaRepository == null)
                {
                    throw new InvalidOperationException("Repositório de colunas não está inicializado.");
                }
                var colunaAdicionada = await _colunaRepository.AddColumn(coluna);
                return colunaAdicionada;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteColumn(int idColuna)
        {
            try
            {
                if (_colunaRepository == null)
                {
                    throw new InvalidOperationException("Repositório de colunas não está inicializado.");
                }
                var valorDaColunaDeletada = await _colunaRepository.DeleteColumn(idColuna);
                return valorDaColunaDeletada;
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
                if (_colunaRepository == null)
                {
                    throw new InvalidOperationException("Repositório de colunas não está inicializado.");
                }
                var colunaAtualizada = await _colunaRepository.UpdateColumn(coluna, idColuna);
                return colunaAtualizada;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Coluna> GetColumnById(int idColuna)
        {
            try
            {
                if (_colunaRepository != null)
                {
                    if (idColuna <= 0)
                    {
                        throw new Exception("Por favor, insira um ID válido.");
                    }
                    var coluna = await _colunaRepository.GetAllColumnById(idColuna);
                    if (coluna == null)
                    {
                        throw new Exception("Desculpe, não encontramos essa coluna no banco de dados.");
                    }
                    return coluna;
                }
                throw new Exception("Não foi possível encontrar o repositório");
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
                if (_colunaRepository != null)
                {
                    var listColumns = await _colunaRepository.GetAllColumns();
                    if (listColumns != null)
                    {
                        return listColumns;
                    }
                    else
                    {
                        throw new Exception("Nenhuma coluna encontrada no banco de dados.");
                    }
                }
                throw new Exception("Não foi possível encontrar o repositório.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Methods Column X Activity
        public async Task<ColunaXAtividade> AddColumnXActivity(ColunaXAtividadeDTO colunaXAtividade)
        {
            try
            {
                if (_colunaXAtividadeRepository == null)
                {
                    throw new InvalidOperationException("Repositório de coluna X atividade não está inicializado.");
                }
                var colunaXAtividadeAdicionada = await _colunaXAtividadeRepository.AddColumnXActivity(colunaXAtividade);
                return colunaXAtividadeAdicionada;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteColumnXActivity(int idColunaXAtividade)
        {
            try
            {
                if (_colunaXAtividadeRepository == null)
                {
                    throw new InvalidOperationException("Repositório de coluna X atividade não está inicializado.");
                }
                var valorColunaXAtividadeDeletado = await _colunaXAtividadeRepository.DeleteColumnXActivity(idColunaXAtividade);
                return valorColunaXAtividadeDeletado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ColunaXAtividade> UpdateColumnXActivity(ColunaXAtividadeDTO colunaXAtividade, int idColunaXAtividade)
        {
            try
            {
                if (_colunaXAtividadeRepository == null)
                {
                    throw new InvalidOperationException("Repositório de coluna X atividade não está inicializado.");
                }
                var colunaXAtividadeAtualizada = await _colunaXAtividadeRepository.UpdateColumnXActivity(colunaXAtividade, idColunaXAtividade);
                return colunaXAtividadeAtualizada;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ColunaXAtividade>> GetAllColumnsXActivity()
        {
            try
            {
                if (_colunaXAtividadeRepository != null)
                {
                    var listColumnsXActivity = await _colunaXAtividadeRepository.GetAllColumnsXActivity();
                    if (listColumnsXActivity != null)
                    {
                        return listColumnsXActivity;
                    }
                    else
                    {
                        throw new Exception("Nenhuma relação coluna X atividade encontrada no banco de dados.");
                    }
                }
                throw new Exception("Não foi possível encontrar o repositório.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ColunaXAtividade> GetColunaXAtividadeById(int idColunaXAtividade)
        {
            try
            {
                if (_colunaXAtividadeRepository != null)
                {
                    if (idColunaXAtividade <= 0)
                    {
                        throw new Exception("Por favor, insira um ID válido.");
                    }
                    var colunaXAtividade = await _colunaXAtividadeRepository.GetAllColumnXActivityById(idColunaXAtividade);
                    if (colunaXAtividade == null)
                    {
                        throw new Exception("Desculpe, não encontramos essa relação coluna X atividade no banco de dados.");
                    }
                    return colunaXAtividade;
                }
                throw new Exception("Não foi possível encontrar o repositório");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
