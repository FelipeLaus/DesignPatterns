namespace Decorator.Descontos
{
    public class DescontoFidelidade : DescontoDecorator
    {
        public DescontoFidelidade(ICalculadoraDesconto calculadora) : base(calculadora) { }

        public override decimal Calcular(Orcamento orcamento)
        {
            return base.Calcular(orcamento) + orcamento.Valor * 0.02m;
        }
    }
}
