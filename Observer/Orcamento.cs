namespace Observer
{
    public class Orcamento
    {
        private readonly List<IObservador> _observadores = new();

        public decimal Valor { get; private set; }
        public TipoOperacao UltimaOperacao { get; private set; }
        public decimal ValorUltimaOperacao { get; private set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
        }

        public void AdicionarObservador(IObservador observador)
        {
            _observadores.Add(observador);
        }

        private void NotificarObservadores()
        {
            foreach (var observador in _observadores)
            {
                observador.Atualizar(this);
            }
        }

        public void AdicionarValor(decimal valorItem)
        {
            Valor += valorItem;
            UltimaOperacao = TipoOperacao.ValorAdicionado;
            ValorUltimaOperacao = valorItem;
            NotificarObservadores();
        }

        public void AplicarDesconto(decimal valorDesconto)
        {
            Valor -= valorDesconto;
            UltimaOperacao = TipoOperacao.DescontoAplicado;
            ValorUltimaOperacao = valorDesconto;
            NotificarObservadores();
        }
    }
}
