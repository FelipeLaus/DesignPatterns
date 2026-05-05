using Visitor.Itens;

namespace Visitor.Visitantes
{
    public class CalculadoraImpostoVisitor : IVisitor
    {
        public decimal TotalImpostos { get; private set; }

        public void Visitar(ItemProduto item)
        {
            TotalImpostos += item.Valor * 0.12m;
        }

        public void Visitar(ItemServico item)
        {
            TotalImpostos += item.Valor * 0.05m;
        }
    }
}
