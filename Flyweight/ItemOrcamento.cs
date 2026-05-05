namespace Flyweight
{
    public class ItemOrcamento
    {
        private readonly TipoItem _tipo;

        public int Quantidade { get; }
        public decimal ValorUnitario { get; }

        public ItemOrcamento(TipoItem tipo, int quantidade, decimal valorUnitario)
        {
            _tipo = tipo;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public decimal Calcular() => Quantidade * ValorUnitario;

        public override string ToString() =>
            $"{_tipo.Nome} ({_tipo.Categoria}) - {Quantidade} {_tipo.Unidade} x R$ {ValorUnitario:F2} = R$ {Calcular():F2}";
    }
}
