namespace Builder
{
    public interface IConstrutorOrcamento
    {
        void DefinirCliente(string cliente);
        void AdicionarItem(string item);
        void AplicarDesconto(decimal desconto);
        void AplicarImposto(decimal imposto);
        Orcamento Construir();
    }
}
