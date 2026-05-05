namespace Interpreter.Expressoes
{
    public class FreteGratisExpressao : IExpressao
    {
        private readonly decimal _valorFrete;

        public FreteGratisExpressao(decimal valorFrete)
        {
            _valorFrete = valorFrete;
        }

        public decimal Interpretar(Contexto contexto)
        {
            contexto.AplicarFreteGratis();
            return _valorFrete;
        }
    }
}
