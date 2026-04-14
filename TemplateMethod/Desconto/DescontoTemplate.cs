namespace TemplateMethod.Desconto
{
    public abstract class DescontoTemplate
    {
        public float CalculaDesconto(Orcamento orcamento)
        {
            if (DeveAplicarDesconto(orcamento))
            {
                return AplicarDesconto(orcamento);
            }

            return 0;
        }

        protected abstract bool DeveAplicarDesconto(Orcamento orcamento);
        protected abstract float AplicarDesconto(Orcamento orcamento);
    }
}
