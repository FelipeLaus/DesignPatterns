using AbstractFactory.Documentos;

namespace AbstractFactory
{
    public interface IFabricaDocumento
    {
        ICabecalho CriarCabecalho();
        ICorpo CriarCorpo();
        IRodape CriarRodape();
    }
}
