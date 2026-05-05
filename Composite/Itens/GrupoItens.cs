namespace Composite.Itens
{
    public class GrupoItens : IItemOrcamento
    {
        private readonly List<IItemOrcamento> _itens = new();

        public string Nome { get; }

        public GrupoItens(string nome)
        {
            Nome = nome;
        }

        public void Adicionar(IItemOrcamento item) => _itens.Add(item);

        public decimal Calcular() => _itens.Sum(i => i.Calcular());

        public void Exibir(int nivel = 0)
        {
            Console.WriteLine($"{new string(' ', nivel * 2)}+ {Nome}: R$ {Calcular():F2}");
            foreach (var item in _itens)
                item.Exibir(nivel + 1);
        }
    }
}
