namespace Iterator.Colecoes
{
    public class ColecaoOrcamentos : IColecaoIteravel<Orcamento>
    {
        private readonly List<Orcamento> _orcamentos = new();

        public void Adicionar(Orcamento orcamento)
        {
            _orcamentos.Add(orcamento);
        }

        public IIterator<Orcamento> CriarIterator()
        {
            return new Iterators.IteradorOrcamentos(_orcamentos);
        }

        public int Quantidade => _orcamentos.Count;
    }
}
