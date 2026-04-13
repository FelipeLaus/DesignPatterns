using Strategy.Impostos;

namespace Strategy
{
    public class CalculadoraDeImpostos
    {
        public float Calcular(Orcamento orcamento, Imposto imposto)
        {
               float valor = imposto.CalculaImposto(orcamento);
               return valor;
        }
    }
}
