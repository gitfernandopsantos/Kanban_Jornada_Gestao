﻿using ApiKanbanGestao.Entity;

namespace ApiKanbanGestao.Dtos
{
    public class ColunaXAtividadeDTO
    {
        public int IdColunaXAtividade { get; set; }
        public Atividade Atividade { get; set; }
        public ColunaXAtividade Coluna { get; set; }
    }
}