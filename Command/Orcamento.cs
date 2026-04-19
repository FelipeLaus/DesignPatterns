namespace Command
{
    public class Orcamento
    {
        public float Valor { get; set; }
        public int Itens { get; set; }

        public Orcamento(float valor, int itens = 0)
        {
            Valor = valor;
            Itens = itens;
        }

        public void AdicionarItem(float valorItem)
        {
            Valor += valorItem;
            Itens++;
        }

        public void AplicarDesconto(float valorDesconto)
        {
            Valor -= valorDesconto;
        }

        public override string ToString()
        {
            return $"Orçamento: Valor = R$ {Valor:F2}, Itens = {Itens}";
        }
    }
}
