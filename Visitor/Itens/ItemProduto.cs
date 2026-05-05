namespace Visitor.Itens
{
    public class ItemProduto : IVisitavel
    {
        public string Nome { get; }
        public decimal Valor { get; }

        public ItemProduto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public void Aceitar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
