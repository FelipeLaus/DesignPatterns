using AbstractFactory.Documentos;

namespace AbstractFactory.Formal
{
    public class CorpoFormal : ICorpo
    {
        public string Gerar(Orcamento orcamento)
        {
            return $"Prezado cliente,\n\nApresentamos o orçamento referente a {orcamento.Itens} item(s).\nValor total: R$ {orcamento.Valor:F2}";
        }
    }
}
