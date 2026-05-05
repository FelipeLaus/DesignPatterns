namespace Composite
{
    public interface IItemOrcamento
    {
        string Nome { get; }
        decimal Calcular();
        void Exibir(int nivel = 0);
    }
}
