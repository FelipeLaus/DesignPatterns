namespace Prototype
{
    public class Orcamento
    {
        public string Cliente { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public List<string> Itens { get; set; } = new();
        public string Tipo { get; set; } = string.Empty;

        public Orcamento Clonar()
        {
            return new Orcamento
            {
                Cliente = Cliente,
                Valor = Valor,
                Itens = new List<string>(Itens),
                Tipo = Tipo
            };
        }

        public override string ToString() =>
            $"[{Tipo}] Cliente: {Cliente} | Itens: {string.Join(", ", Itens)} | Valor: R$ {Valor:F2}";
    }
}
