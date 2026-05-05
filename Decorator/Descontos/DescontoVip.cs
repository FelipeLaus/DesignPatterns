namespace Decorator.Descontos
{
    public class DescontoVip : DescontoDecorator
    {
        public DescontoVip(ICalculadoraDesconto calculadora) : base(calculadora) { }

        public override decimal Calcular(Orcamento orcamento)
        {
            return base.Calcular(orcamento) + orcamento.Valor * 0.05m;
        }
    }
}
