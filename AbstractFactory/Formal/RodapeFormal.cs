using AbstractFactory.Documentos;

namespace AbstractFactory.Formal
{
    public class RodapeFormal : IRodape
    {
        public string Gerar(Orcamento orcamento)
        {
            return "Atenciosamente,\nDepartamento Comercial\n[Assinatura e CNPJ]";
        }
    }
}
