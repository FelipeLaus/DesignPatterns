namespace Interpreter.Expressoes
{
    public class DescontoExpressao : IExpressao
    {
        private readonly decimal _percentual;

        public DescontoExpressao(decimal percentual)
        {
            _percentual = percentual;
        }

        public decimal Interpretar(Contexto contexto)
        {
            return contexto.ValorOrcamento * (_percentual / 100m);
        }
    }
}
