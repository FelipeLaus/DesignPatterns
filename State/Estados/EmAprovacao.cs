namespace State
{
    public class EmAprovacao : EstadoOrcamento
    {
        public override float CalculaDescontoExtra(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05f;
        }

        public override void Aprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public override void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
