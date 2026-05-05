namespace Builder
{
    public class DiretorOrcamento
    {
        private readonly IConstrutorOrcamento _construtor;

        public DiretorOrcamento(IConstrutorOrcamento construtor)
        {
            _construtor = construtor;
        }

        public Orcamento ConstruirOrcamentoCorporativo(string cliente)
        {
            _construtor.DefinirCliente(cliente);
            _construtor.AdicionarItem("Notebook");
            _construtor.AdicionarItem("Monitor");
            _construtor.AdicionarItem("Teclado");
            _construtor.AplicarDesconto(50m);
            _construtor.AplicarImposto(30m);
            return _construtor.Construir();
        }

        public Orcamento ConstruirOrcamentoBasico(string cliente)
        {
            _construtor.DefinirCliente(cliente);
            _construtor.AdicionarItem("Mouse");
            return _construtor.Construir();
        }
    }
}
