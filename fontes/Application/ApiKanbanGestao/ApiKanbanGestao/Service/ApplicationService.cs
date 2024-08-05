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
        public Task<Atividade> AddActivity(Atividade atividade)
        {
            try
            {
                if (_atividadeRepository != null)
                {
                    _atividadeRepository.AddActivity(atividade);
                }
                throw new InvalidOperationException("Repositório de atividades não está inicializado.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public Task<Atividade> UpdateActivity(Atividade atividade, int idAtividade)
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
        public Task<ColunaDTO> AddColumn(ColunaXAtividade coluna)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteColumn(int idColuna)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaDTO> EditColumn(ColunaXAtividade coluna, int idColuna)
        {
            throw new NotImplementedException();
        }
        public Task<ColunaDTO> GetAllColumnById(int idAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColunaDTO>> GetAllColumns()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Methods Column X Activity
        public Task<ColunaXAtividadeDTO> AddColumnXActivity(ColunaXAtividade colunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteColumnXActivity(int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<ColunaXAtividadeDTO> EditColumnXActivity(ColunaXAtividade colunaXAtividade, int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColunaXAtividadeDTO>> GetAllColumnsXActivity()
        {
            throw new NotImplementedException();
        }

        public Task<ColunaXAtividadeDTO> GetAllColumnXActivityById(int idColunaXAtividade)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
