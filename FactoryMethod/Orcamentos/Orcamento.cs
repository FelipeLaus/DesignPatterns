namespace FactoryMethod.Orcamentos
{
    public abstract class Orcamento
    {
        public string Cliente { get; set; } = string.Empty;
        public decimal Valor { get; set; }

        public abstract string Descricao();

        public override string ToString() => $"{Descricao()} | Cliente: {Cliente} | Valor: R$ {Valor:F2}";
    }
}
