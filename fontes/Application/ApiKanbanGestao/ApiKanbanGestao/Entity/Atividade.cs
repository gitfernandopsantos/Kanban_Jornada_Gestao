namespace ApiKanbanGestao.Entity
{
    public class Atividade
    {
        public int IdAtividade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Atividade(int idAtividade, string nome, string descricao, DateTime dataCriacao, DateTime dataInicio, DateTime dataFim)
        {
            IdAtividade = idAtividade;
            Nome = nome;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
