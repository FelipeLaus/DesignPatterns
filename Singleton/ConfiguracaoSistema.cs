namespace Singleton
{
    public class ConfiguracaoSistema
    {
        private static ConfiguracaoSistema? _instancia;
        private static readonly object _lock = new();

        public string MoedaPadrao { get; set; } = "BRL";
        public decimal ImpostopadraoPct { get; set; } = 0.12m;
        public int DiasValidadeOrcamento { get; set; } = 30;

        private ConfiguracaoSistema() { }

        public static ConfiguracaoSistema Instancia
        {
            get
            {
                if (_instancia is null)
                {
                    lock (_lock)
                    {
                        _instancia ??= new ConfiguracaoSistema();
                    }
                }

                return _instancia;
            }
        }

        public override string ToString() =>
            $"Moeda: {MoedaPadrao} | Imposto: {ImpostopadraoPct * 100}% | Validade: {DiasValidadeOrcamento} dias";
    }
}
