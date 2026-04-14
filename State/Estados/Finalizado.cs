using System;

namespace State
{
    public class Finalizado : EstadoOrcamento
    {
        public override float CalculaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não podem receber desconto extra");
        }
    }
}
