namespace Iterator
{
    public class Orcamento
    {
        public decimal Valor { get; set; }
        public string Cliente { get; set; }

        public Orcamento(decimal valor, string cliente)
        {
            Valor = valor;
            Cliente = cliente;
        }

        public override string ToString()
        {
            return $"Cliente: {Cliente}, Valor: R$ {Valor:F2}";
        }
    }
}
