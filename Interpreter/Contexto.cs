namespace Interpreter
{
    public class Contexto
    {
        public decimal ValorOrcamento { get; }
        public bool FreteGratis { get; private set; }

        public Contexto(decimal valorOrcamento)
        {
            ValorOrcamento = valorOrcamento;
        }

        public void AplicarFreteGratis() => FreteGratis = true;
    }
}
