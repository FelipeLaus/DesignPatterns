using AbstractFactory.Documentos;

namespace AbstractFactory.Simplificado
{
    public class RodapeSimplificado : IRodape
    {
        public string Gerar(Orcamento orcamento)
        {
            return "Validade: 7 dias.";
        }
    }
}
