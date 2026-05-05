using AbstractFactory.Documentos;

namespace AbstractFactory.Formal
{
    public class FabricaDocumentoFormal : IFabricaDocumento
    {
        public ICabecalho CriarCabecalho() => new CabecalhoFormal();
        public ICorpo CriarCorpo() => new CorpoFormal();
        public IRodape CriarRodape() => new RodapeFormal();
    }
}
