using AbstractFactory.Documentos;

namespace AbstractFactory.Formal
{
    public class CabecalhoFormal : ICabecalho
    {
        public string Gerar(Orcamento orcamento)
        {
            return $"ORÇAMENTO EMPRESARIAL\nCliente: {orcamento.Cliente}\nData: {DateTime.Now:dd/MM/yyyy}";
        }
    }
}
