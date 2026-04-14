namespace State
{
    public class Aprovado : EstadoOrcamento
    {
        public override float CalculaDescontoExtra(Orcamento orcamento)
        {
            return orcamento.Valor * 0.02f;
        }

        public override void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }
}
