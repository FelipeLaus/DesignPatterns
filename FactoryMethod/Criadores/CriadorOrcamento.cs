using FactoryMethod.Orcamentos;

namespace FactoryMethod.Criadores
{
    public abstract class CriadorOrcamento
    {
        protected abstract Orcamento CriarOrcamento();

        public Orcamento ProcessarOrcamento(string cliente, decimal valor)
        {
            var orcamento = CriarOrcamento();
            orcamento.Cliente = cliente;
            orcamento.Valor = valor;
            return orcamento;
        }
    }
}
