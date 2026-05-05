namespace Memento
{
    public class HistoricoOrcamento
    {
        private readonly Stack<MementoOrcamento> _historico = new();

        public void Salvar(Orcamento orcamento)
        {
            _historico.Push(orcamento.SalvarEstado());
        }

        public void Desfazer(Orcamento orcamento)
        {
            if (_historico.Count == 0)
            {
                Console.WriteLine("Nenhum estado salvo para restaurar.");
                return;
            }

            orcamento.RestaurarEstado(_historico.Pop());
        }
    }
}
