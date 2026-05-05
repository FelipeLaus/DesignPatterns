namespace Mediator.Departamentos
{
    public class DepartamentoEstoque : Departamento
    {
        public override void Reagir(string evento)
        {
            if (evento == "PedidoAprovado")
            {
                Console.WriteLine("Estoque: Reservando itens para o pedido.");
                Mediador?.Notificar(this, "EstoqueReservado");
            }
        }
    }
}
