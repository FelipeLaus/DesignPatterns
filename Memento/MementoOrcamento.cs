namespace Memento
{
    public class MementoOrcamento
    {
        public decimal Valor { get; }
        public string Situacao { get; }

        internal MementoOrcamento(decimal valor, string situacao)
        {
            Valor = valor;
            Situacao = situacao;
        }
    }
}
