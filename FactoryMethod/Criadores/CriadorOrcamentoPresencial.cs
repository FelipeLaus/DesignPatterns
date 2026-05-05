using FactoryMethod.Orcamentos;

namespace FactoryMethod.Criadores
{
    public class CriadorOrcamentoPresencial : CriadorOrcamento
    {
        protected override Orcamento CriarOrcamento() => new OrcamentoPresencial();
    }
}
