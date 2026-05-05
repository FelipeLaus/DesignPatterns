namespace Memento
{
    public class Orcamento
    {
        public decimal Valor { get; private set; }
        public string Situacao { get; private set; }

        public Orcamento(decimal valor, string situacao)
        {
            Valor = valor;
            Situacao = situacao;
        }

        public void AlterarValor(decimal novoValor) => Valor = novoValor;

        public void AlterarSituacao(string novaSituacao) => Situacao = novaSituacao;

        public MementoOrcamento SalvarEstado() => new(Valor, Situacao);

        public void RestaurarEstado(MementoOrcamento memento)
        {
            Valor = memento.Valor;
            Situacao = memento.Situacao;
        }

        public override string ToString() => $"Orçamento [Valor: R$ {Valor:F2}, Situação: {Situacao}]";
    }
}
