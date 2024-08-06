namespace ApiKanbanGestao.Entity
{
    public class Coluna
    {
        public int IdColuna { get; set; }
        public string Nome { get; set; }

        public Coluna(string nome)
        {
            Nome = nome;
        }
    }
}
