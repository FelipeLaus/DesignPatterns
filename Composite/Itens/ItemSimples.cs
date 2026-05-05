namespace Composite.Itens
{
    public class ItemSimples : IItemOrcamento
    {
        public string Nome { get; }
        public decimal Valor { get; }

        public ItemSimples(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public decimal Calcular() => Valor;

        public void Exibir(int nivel = 0)
        {
            Console.WriteLine($"{new string(' ', nivel * 2)}- {Nome}: R$ {Valor:F2}");
        }
    }
}
