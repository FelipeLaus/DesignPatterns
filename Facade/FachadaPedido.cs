using Facade.Servicos;

namespace Facade
{
    public class FachadaPedido
    {
        private readonly ServicoEstoque _estoque = new();
        private readonly ServicoFinanceiro _financeiro = new();
        private readonly ServicoExpedicao _expedicao = new();

        public void FecharPedido(Orcamento orcamento)
        {
            Console.WriteLine($"--- Fechando pedido para {orcamento.Cliente} ---");
            _estoque.ReservarItens(orcamento);
            _financeiro.ProcessarPagamento(orcamento);
            _expedicao.AgendarEntrega(orcamento);
            Console.WriteLine("Pedido concluído com sucesso.");
        }
    }
}
