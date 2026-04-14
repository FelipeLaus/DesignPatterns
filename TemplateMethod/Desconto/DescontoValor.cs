namespace TemplateMethod.Desconto
{
    public class DescontoValor : DescontoTemplate
    {
        protected override bool DeveAplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        protected override float AplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05f;
        }
    }
}
