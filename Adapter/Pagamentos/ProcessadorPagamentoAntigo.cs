namespace Adapter.Pagamentos
{
    public class ProcessadorPagamentoAntigo
    {
        public void ProcessarXml(string xml)
        {
            Console.WriteLine($"Pagamento processado via sistema legado (XML): {xml}");
        }
    }
}
