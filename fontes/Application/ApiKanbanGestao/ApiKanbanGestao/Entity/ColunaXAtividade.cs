namespace ApiKanbanGestao.Entity
{
    public class ColunaXAtividade
    {
        public int IdColunaXAtividade { get; set; }
        public Atividade Atividade { get; set; }
        public Coluna Coluna { get; set; }
        

        public ColunaXAtividade(int idColunaXAtividade, Atividade atividade, Coluna coluna)
        {
            IdColunaXAtividade = idColunaXAtividade;
            Atividade = atividade;
            Coluna = coluna;
        }
    }
}
