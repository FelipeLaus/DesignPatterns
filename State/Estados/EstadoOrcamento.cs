namespace State
{
    public abstract class EstadoOrcamento
    {
        public abstract float CalculaDescontoExtra(Orcamento orcamento);
        
        public virtual void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar este orçamento no estado atual");
        }

        public virtual void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar este orçamento no estado atual");
        }

        public virtual void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Não é possível finalizar este orçamento no estado atual");
        }
    }
}
