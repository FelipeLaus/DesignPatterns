using Bridge.Formatos;

namespace Bridge.Relatorios
{
    public class RelatorioDetalhado : RelatorioOrcamento
    {
        public RelatorioDetalhado(IFormatoRelatorio formato) : base(formato) { }

        public override string Gerar(Orcamento orcamento)
        {
            var conteudo = $"Cliente: {orcamento.Cliente} | Itens: {orcamento.Itens} | Valor: R$ {orcamento.Valor:F2} | Média por item: R$ {orcamento.Valor / orcamento.Itens:F2}";
            return Formato.Formatar("Relatório Detalhado", conteudo);
        }
    }
}
