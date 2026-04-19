namespace Command.Comandos
{
    public class AdicionarItem : IComando
    {
        private readonly Orcamento _orcamento;
        private readonly float _valorItem;

        public AdicionarItem(Orcamento orcamento, float valorItem)
        {
            _orcamento = orcamento;
            _valorItem = valorItem;
        }

        public void Executar()
        {
            _orcamento.AdicionarItem(_valorItem);
        }
    }
}
