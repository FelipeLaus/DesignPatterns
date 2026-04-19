namespace Command.Comandos
{
    public class AplicarDesconto : IComando
    {
        private readonly Orcamento _orcamento;
        private readonly float _valorDesconto;

        public AplicarDesconto(Orcamento orcamento, float valorDesconto)
        {
            _orcamento = orcamento;
            _valorDesconto = valorDesconto;
        }

        public void Executar()
        {
            _orcamento.AplicarDesconto(_valorDesconto);
        }
    }
}
