using TemplateMethod.Desconto;

namespace TemplateMethod
{
    public class CalculadoraDesconto
    {
        private readonly List<DescontoTemplate> _descontos;

        public CalculadoraDesconto()
        {
            _descontos = new List<DescontoTemplate>
            {
                new DescontoItens(),
                new DescontoValor()
            };
        }

        public float Calcula(Orcamento orcamento)
        {
            foreach (var desconto in _descontos)
            {
                float valorDesconto = desconto.CalculaDesconto(orcamento);
                if (valorDesconto > 0)
                {
                    return valorDesconto;
                }
            }

            return 0;
        }
    }
}
