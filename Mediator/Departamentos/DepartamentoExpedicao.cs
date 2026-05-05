namespace Mediator.Departamentos
{
    public class DepartamentoExpedicao : Departamento
    {
        public override void Reagir(string evento)
        {
            if (evento == "EstoqueReservado")
                Console.WriteLine("Expedição: Agendando entrega do pedido.");
        }
    }
}
