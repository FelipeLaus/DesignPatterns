namespace Proxy.Impostos
{
    public class CalculadoraImposto : ICalculadoraImposto
    {
        public decimal Calcular(Orcamento orcamento)
        {
            Console.WriteLine("[Real] Calculando imposto...");
            Thread.Sleep(500); // simula processamento custoso
            return orcamento.Valor * 0.15m;
        }
    }
}
