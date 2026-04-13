using Strategy;

namespace ChainOfResponsability.Desconto
{
    public abstract class DescontoOrcamento
    {
        protected DescontoOrcamento? ProximoDesconto { get; set; } = null;

        public void SetProximoDesconto(DescontoOrcamento proximoDesconto)
        {
            this.ProximoDesconto = proximoDesconto;
        }

        abstract public float CalculaDesconto(Orcamento orcamento);
    }
}
