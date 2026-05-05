using Mediator.Departamentos;

namespace Mediator
{
    public class MediadorPedido : IMediator
    {
        private readonly List<Departamento> _departamentos = new();

        public void AdicionarDepartamento(Departamento departamento)
        {
            departamento.DefinirMediator(this);
            _departamentos.Add(departamento);
        }

        public void Notificar(Departamento remetente, string evento)
        {
            foreach (var departamento in _departamentos)
            {
                if (departamento != remetente)
                    departamento.Reagir(evento);
            }
        }
    }
}
