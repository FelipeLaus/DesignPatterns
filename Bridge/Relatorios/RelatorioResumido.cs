using Bridge.Formatos;

namespace Bridge.Relatorios
{
    public class RelatorioResumido : RelatorioOrcamento
    {
        public RelatorioResumido(IFormatoRelatorio formato) : base(formato) { }

        public override string Gerar(Orcamento orcamento)
        {
            var conteudo = $"Cliente: {orcamento.Cliente} | Valor: R$ {orcamento.Valor:F2}";
            return Formato.Formatar("Relatório Resumido", conteudo);
        }
    }
}
