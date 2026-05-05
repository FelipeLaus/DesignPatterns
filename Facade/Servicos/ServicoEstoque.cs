namespace Facade.Servicos
{
    public class ServicoEstoque
    {
        public void ReservarItens(Orcamento orcamento)
        {
            Console.WriteLine($"Estoque: {orcamento.Itens} item(s) reservado(s).");
        }
    }
}
