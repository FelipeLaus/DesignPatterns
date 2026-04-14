using System;

namespace State
{
    public class Reprovado : EstadoOrcamento
    {
        public override float CalculaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não podem receber desconto extra");
        }

        public override void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }
}
