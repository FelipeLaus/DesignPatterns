namespace Observer.Observadores
{
    public class RegistroAlteracoes : IObservador
    {
        public void Atualizar(Orcamento orcamento)
        {
            string mensagem = orcamento.UltimaOperacao switch
            {
                TipoOperacao.ValorAdicionado => $"LOG: Valor adicionado R$ {orcamento.ValorUltimaOperacao:F2}",
                TipoOperacao.DescontoAplicado => $"LOG: Desconto aplicado R$ {orcamento.ValorUltimaOperacao:F2}",
                _ => $"LOG: Orçamento alterado"
            };

            Console.WriteLine(mensagem);
        }
    }
}
