namespace Flyweight
{
    public class FabricaTipoItem
    {
        private readonly Dictionary<string, TipoItem> _cache = new();

        public TipoItem Obter(string nome, string categoria, string unidade)
        {
            if (!_cache.TryGetValue(nome, out var tipo))
            {
                tipo = new TipoItem(nome, categoria, unidade);
                _cache[nome] = tipo;
                Console.WriteLine($"[Flyweight] Novo tipo criado: {nome}");
            }

            return tipo;
        }

        public int TotalTiposCriados => _cache.Count;
    }
}
