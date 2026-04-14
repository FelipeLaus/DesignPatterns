namespace TemplateMethod.Desconto
{
    public class DescontoItens : DescontoTemplate
    {
        protected override bool DeveAplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Itens > 5;
        }

        protected override float AplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1f;
        }
    }
}
