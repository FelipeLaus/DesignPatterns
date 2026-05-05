namespace AbstractFactory
{
    public class GeradorDocumento
    {
        private readonly IFabricaDocumento _fabrica;

        public GeradorDocumento(IFabricaDocumento fabrica)
        {
            _fabrica = fabrica;
        }

        public void Gerar(Orcamento orcamento)
        {
            var cabecalho = _fabrica.CriarCabecalho();
            var corpo = _fabrica.CriarCorpo();
            var rodape = _fabrica.CriarRodape();

            Console.WriteLine(cabecalho.Gerar(orcamento));
            Console.WriteLine(corpo.Gerar(orcamento));
            Console.WriteLine(rodape.Gerar(orcamento));
        }
    }
}
