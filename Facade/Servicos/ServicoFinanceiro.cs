namespace Facade.Servicos
{
    public class ServicoFinanceiro
    {
        public void ProcessarPagamento(Orcamento orcamento)
        {
            Console.WriteLine($"Financeiro: Pagamento de R$ {orcamento.Valor:F2} processado para {orcamento.Cliente}.");
        }
    }
}
