namespace Decorator.Descontos
{
    public class DescontoCupom : DescontoDecorator
    {
        private readonly decimal _valorCupom;

        public DescontoCupom(ICalculadoraDesconto calculadora, decimal valorCupom) : base(calculadora)
        {
            _valorCupom = valorCupom;
        }

        public override decimal Calcular(Orcamento orcamento)
        {
            return base.Calcular(orcamento) + _valorCupom;
        }
    }
}
