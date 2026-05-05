namespace Builder
{
    public class Orcamento
    {
        public string Cliente { get; set; } = string.Empty;
        public List<string> Itens { get; set; } = new();
        public decimal Desconto { get; set; }
        public decimal Imposto { get; set; }

        public decimal ValorBruto => Itens.Count * 100m;
        public decimal ValorTotal => ValorBruto - Desconto + Imposto;

        public override string ToString()
        {
            return $"Cliente: {Cliente}\nItens: {string.Join(", ", Itens)}\nBruto: R$ {ValorBruto:F2} | Desconto: R$ {Desconto:F2} | Imposto: R$ {Imposto:F2}\nTotal: R$ {ValorTotal:F2}";
        }
    }
}
