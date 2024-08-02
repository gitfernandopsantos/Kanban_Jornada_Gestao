using System.ComponentModel.DataAnnotations;

namespace ApiKanbanGestao.Entity
{
    public class Atividade
    {
        [Required]
        public int IdAtividade { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
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
