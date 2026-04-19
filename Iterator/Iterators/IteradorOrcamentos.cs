namespace Iterator.Iterators
{
    public class IteradorOrcamentos : IIterator<Orcamento>
    {
        private readonly List<Orcamento> _orcamentos;
        private int _posicaoAtual = 0;

        public IteradorOrcamentos(List<Orcamento> orcamentos)
        {
            _orcamentos = orcamentos;
        }

        public bool TemProximo()
        {
            return _posicaoAtual < _orcamentos.Count;
        }

        public Orcamento Proximo()
        {
            if (!TemProximo())
            {
                throw new InvalidOperationException("Não há mais elementos para iterar.");
            }

            return _orcamentos[_posicaoAtual++];
        }

        public void Reiniciar()
        {
            _posicaoAtual = 0;
        }
    }
}
