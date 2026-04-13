using Strategy;

namespace ChainOfResponsability.Desconto
{
    public class SemDesconto : DescontoOrcamento
    {
        public override float CalculaDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens > 5)
            {
                return orcamento.Valor * 0.1f;
            }


            if (ProximoDesconto != null)
                return ProximoDesconto.CalculaDesconto(orcamento);
            else
                return 0;
        }
    }
}
