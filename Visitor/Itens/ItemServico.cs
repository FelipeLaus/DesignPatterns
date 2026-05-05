namespace Visitor.Itens
{
    public class ItemServico : IVisitavel
    {
        public string Descricao { get; }
        public decimal Valor { get; }
        public int HorasTrabalhadas { get; }

        public ItemServico(string descricao, decimal valor, int horasTrabalhadas)
        {
            Descricao = descricao;
            Valor = valor;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public void Aceitar(IVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
