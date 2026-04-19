namespace Observer.Observadores
{
    public class CalculadoraDesconto : IObservador
    {
        private readonly decimal _valorMinimoDesconto;
        private bool _descontoAplicado = false;

        public CalculadoraDesconto(decimal valorMinimoDesconto)
        {
            _valorMinimoDesconto = valorMinimoDesconto;
        }

        public void Atualizar(Orcamento orcamento)
        {
            if (!_descontoAplicado && orcamento.Valor >= _valorMinimoDesconto)
            {
                decimal desconto = orcamento.Valor * 0.05m;
                _descontoAplicado = true;
            }
        }
    }
}
