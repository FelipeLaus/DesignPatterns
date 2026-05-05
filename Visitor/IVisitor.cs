using Visitor.Itens;

namespace Visitor
{
    public interface IVisitor
    {
        void Visitar(ItemProduto item);
        void Visitar(ItemServico item);
    }
}
