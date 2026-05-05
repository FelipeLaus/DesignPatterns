namespace Decorator.Descontos
{
    public class CalculadoraBase : ICalculadoraDesconto
    {
        public decimal Calcular(Orcamento orcamento) => 0m;
    }
}
