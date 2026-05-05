namespace Interpreter.Expressoes
{
    public class SomaExpressao : IExpressao
    {
        private readonly IExpressao _esquerda;
        private readonly IExpressao _direita;

        public SomaExpressao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public decimal Interpretar(Contexto contexto)
        {
            return _esquerda.Interpretar(contexto) + _direita.Interpretar(contexto);
        }
    }
}
