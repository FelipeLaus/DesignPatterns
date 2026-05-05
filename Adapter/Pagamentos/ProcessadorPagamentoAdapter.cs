namespace Adapter.Pagamentos
{
    public class ProcessadorPagamentoAdapter : IProcessadorPagamento
    {
        private readonly ProcessadorPagamentoAntigo _processadorAntigo;

        public ProcessadorPagamentoAdapter(ProcessadorPagamentoAntigo processadorAntigo)
        {
            _processadorAntigo = processadorAntigo;
        }

        public void ProcessarPagamento(Orcamento orcamento)
        {
            var xml = $"<pagamento><valor>{orcamento.Valor}</valor><itens>{orcamento.Itens}</itens></pagamento>";
            _processadorAntigo.ProcessarXml(xml);
        }
    }
}
