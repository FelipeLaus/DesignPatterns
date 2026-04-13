using Strategy;

namespace ChainOfResponsability.Desconto
{
    public class DescontoValor : DescontoOrcamento
    {
        public override float CalculaDesconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.05f;
            }


            if (ProximoDesconto != null)
                return ProximoDesconto.CalculaDesconto(orcamento);
            else
                return 0;
        }
    }
}
