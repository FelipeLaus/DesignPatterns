namespace Mediator.Departamentos
{
    public class DepartamentoFinanceiro : Departamento
    {
        public void AprovarPedido()
        {
            Console.WriteLine("Financeiro: Pedido aprovado.");
            Mediador?.Notificar(this, "PedidoAprovado");
        }

        public override void Reagir(string evento)
        {
            if (evento == "EstoqueReservado")
                Console.WriteLine("Financeiro: Estoque confirmado, emitindo nota fiscal.");
        }
    }
}
