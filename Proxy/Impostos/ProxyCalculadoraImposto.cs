namespace Proxy.Impostos
{
    public class ProxyCalculadoraImposto : ICalculadoraImposto
    {
        private readonly CalculadoraImposto _calculadora = new();
        private decimal? _cache;

        public decimal Calcular(Orcamento orcamento)
        {
            if (_cache.HasValue)
            {
                Console.WriteLine("[Proxy] Retornando valor em cache.");
                return _cache.Value;
            }

            _cache = _calculadora.Calcular(orcamento);
            return _cache.Value;
        }
    }
}
