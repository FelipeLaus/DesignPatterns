using AbstractFactory.Documentos;

namespace AbstractFactory.Simplificado
{
    public class CorpoSimplificado : ICorpo
    {
        public string Gerar(Orcamento orcamento)
        {
            return $"Itens: {orcamento.Itens} | Total: R$ {orcamento.Valor:F2}";
        }
    }
}
