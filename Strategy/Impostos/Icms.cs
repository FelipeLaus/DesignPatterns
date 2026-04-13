namespace Strategy.Impostos
{
    public class Icms : Imposto
    {
        public float CalculaImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1f;
        }
    }
}
