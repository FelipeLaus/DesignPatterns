namespace Flyweight
{
    public class TipoItem
    {
        public string Nome { get; }
        public string Categoria { get; }
        public string Unidade { get; }

        public TipoItem(string nome, string categoria, string unidade)
        {
            Nome = nome;
            Categoria = categoria;
            Unidade = unidade;
        }
    }
}
