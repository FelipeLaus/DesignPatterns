using Strategy;
using ChainOfResponsability.Desconto;

namespace ChainOfResponsability
{
    public class CalculadoraDesconto
    {
        private readonly DescontoOrcamento _cadeia;

        public CalculadoraDesconto()
        {
            var desconto1 = new DescontoItens();
            var desconto2 = new DescontoValor();
            var desconto3 = new SemDesconto();

            desconto1.SetProximoDesconto(desconto2);
            desconto2.SetProximoDesconto(desconto3);

            _cadeia = desconto1;
        }

        public float Calcula(Orcamento orcamento)
        {
            return _cadeia.CalculaDesconto(orcamento);
        }
    }
}
