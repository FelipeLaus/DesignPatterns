using Bridge.Formatos;

namespace Bridge.Relatorios
{
    public abstract class RelatorioOrcamento
    {
        protected readonly IFormatoRelatorio Formato;

        protected RelatorioOrcamento(IFormatoRelatorio formato)
        {
            Formato = formato;
        }

        public abstract string Gerar(Orcamento orcamento);
    }
}
