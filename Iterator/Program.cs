using Iterator;
using Iterator.Colecoes;

ColecaoOrcamentos colecao = new ColecaoOrcamentos();

// Adicionando orçamentos
colecao.Adicionar(new Orcamento(1500m, "João Silva"));
colecao.Adicionar(new Orcamento(2300m, "Maria Santos"));
colecao.Adicionar(new Orcamento(890m, "Pedro Costa"));
colecao.Adicionar(new Orcamento(4200m, "Ana Oliveira"));
colecao.Adicionar(new Orcamento(1100m, "Carlos Souza"));

Console.WriteLine($"Total de orçamentos: {colecao.Quantidade}\n");

// Criando um iterator para percorrer a coleção
IIterator<Orcamento> iterator = colecao.CriarIterator();

while (iterator.TemProximo())
{
    Orcamento orcamento = iterator.Proximo();
    Console.WriteLine(orcamento.ToString());
}