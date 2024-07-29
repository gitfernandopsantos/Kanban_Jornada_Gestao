namespace ApiKanbanGestao.Dtos
{
    public class AtividadeDTO
    {
        public int IdAtividade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
