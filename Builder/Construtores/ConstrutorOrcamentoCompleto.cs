namespace Builder.Construtores
{
    public class ConstrutorOrcamentoCompleto : IConstrutorOrcamento
    {
        private readonly Orcamento _orcamento = new();

        public void DefinirCliente(string cliente) => _orcamento.Cliente = cliente;
        public void AdicionarItem(string item) => _orcamento.Itens.Add(item);
        public void AplicarDesconto(decimal desconto) => _orcamento.Desconto = desconto;
        public void AplicarImposto(decimal imposto) => _orcamento.Imposto = imposto;
        public Orcamento Construir() => _orcamento;
    }
}
