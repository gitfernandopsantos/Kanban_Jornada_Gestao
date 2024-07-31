namespace ApiKanbanGestao.Entity
{
    public class ColunaXAtividade
    {
        public int IdColunaXAtividade { get; set; }
        public int AtividadeId { get; set; }
        public int ColunaId { get; set; }
        public virtual Atividade Atividade { get; set; }
        public virtual Coluna Coluna { get; set; }

    }
}
