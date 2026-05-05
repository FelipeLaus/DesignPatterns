namespace Decorator.Descontos
{
    public abstract class DescontoDecorator : ICalculadoraDesconto
    {
        private readonly ICalculadoraDesconto _calculadora;

        protected DescontoDecorator(ICalculadoraDesconto calculadora)
        {
            _calculadora = calculadora;
        }

        public virtual decimal Calcular(Orcamento orcamento)
        {
            return _calculadora.Calcular(orcamento);
        }
    }
}
