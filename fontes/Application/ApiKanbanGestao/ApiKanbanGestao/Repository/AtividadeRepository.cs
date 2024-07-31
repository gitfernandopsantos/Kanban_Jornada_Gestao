﻿using ApiKanbanGestao.DataDbContext;
using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IRepository;

namespace ApiKanbanGestao.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly KanbanGestaoDbContext _kanbanGestaoDb;
        public AtividadeRepository(KanbanGestaoDbContext kanbanGestaoDbContext)
        {
            _kanbanGestaoDb = kanbanGestaoDbContext;
        }
        public Task<AtividadeDTO> AddActivity(Atividade atividade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteActivity(int idAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<AtividadeDTO> EditActivity(Atividade atividade, int idAtividade)
        {
            throw new NotImplementedException();
        }

        public Task<List<AtividadeDTO>> GetAllActivity()
        {
            throw new NotImplementedException();
        }

        public Task<AtividadeDTO> GetAllActivityById(int idAtividade)
        {
            throw new NotImplementedException();
        }
    }
}