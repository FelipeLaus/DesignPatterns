using AbstractFactory.Documentos;

namespace AbstractFactory.Simplificado
{
    public class CabecalhoSimplificado : ICabecalho
    {
        public string Gerar(Orcamento orcamento)
        {
            return $"Orçamento - {orcamento.Cliente} ({DateTime.Now:dd/MM/yyyy})";
        }
    }
}
