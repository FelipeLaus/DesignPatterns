namespace Mediator.Departamentos
{
    public abstract class Departamento
    {
        protected IMediator? Mediador { get; private set; }

        public void DefinirMediator(IMediator mediador)
        {
            Mediador = mediador;
        }

        public abstract void Reagir(string evento);
    }
}
