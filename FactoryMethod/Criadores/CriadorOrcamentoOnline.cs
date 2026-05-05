using FactoryMethod.Orcamentos;

namespace FactoryMethod.Criadores
{
    public class CriadorOrcamentoOnline : CriadorOrcamento
    {
        protected override Orcamento CriarOrcamento() => new OrcamentoOnline();
    }
}
