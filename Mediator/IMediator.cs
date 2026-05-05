using Mediator.Departamentos;

namespace Mediator
{
    public interface IMediator
    {
        void Notificar(Departamento remetente, string evento);
    }
}
