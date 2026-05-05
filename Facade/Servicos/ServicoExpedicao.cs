namespace Facade.Servicos
{
    public class ServicoExpedicao
    {
        public void AgendarEntrega(Orcamento orcamento)
        {
            Console.WriteLine($"Expedição: Entrega agendada para {orcamento.Cliente}.");
        }
    }
}
