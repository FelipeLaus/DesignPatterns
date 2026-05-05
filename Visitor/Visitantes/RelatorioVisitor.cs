using Visitor.Itens;

namespace Visitor.Visitantes
{
    public class RelatorioVisitor : IVisitor
    {
        private readonly List<string> _linhas = new();

        public void Visitar(ItemProduto item)
        {
            _linhas.Add($"Produto: {item.Nome} - R$ {item.Valor:F2} (ICMS: R$ {item.Valor * 0.12m:F2})");
        }

        public void Visitar(ItemServico item)
        {
            _linhas.Add($"Serviço: {item.Descricao} - R$ {item.Valor:F2} ({item.HorasTrabalhadas}h - ISS: R$ {item.Valor * 0.05m:F2})");
        }

        public string GerarRelatorio() => string.Join("\n", _linhas);
    }
}
