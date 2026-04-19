using Command;
using Command.Comandos;

// Criando um orçamento inicial
Orcamento orcamento = new Orcamento(1000f);
Console.WriteLine(orcamento);

// Criando comandos
IComando comando1 = new AdicionarItem(orcamento, 150f);
IComando comando2 = new AdicionarItem(orcamento, 200f);
IComando comando3 = new AplicarDesconto(orcamento, 100f);

// Executando comandos diretamente
comando1.Executar();
Console.WriteLine(orcamento);

comando2.Executar();
Console.WriteLine(orcamento);

comando3.Executar();
Console.WriteLine(orcamento);