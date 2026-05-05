using AbstractFactory.Documentos;

namespace AbstractFactory.Simplificado
{
    public class FabricaDocumentoSimplificado : IFabricaDocumento
    {
        public ICabecalho CriarCabecalho() => new CabecalhoSimplificado();
        public ICorpo CriarCorpo() => new CorpoSimplificado();
        public IRodape CriarRodape() => new RodapeSimplificado();
    }
}
