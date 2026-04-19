using Observer;
using Observer.Observadores;

// Criando um orçamento
Orcamento orcamento = new Orcamento(500m);

// Criando observadores
IObservador registroLog = new RegistroAlteracoes();
IObservador calculadoraDesconto = new CalculadoraDesconto(1500m);

// Registrando observadores no orçamento
orcamento.AdicionarObservador(registroLog);
orcamento.AdicionarObservador(calculadoraDesconto);

Console.WriteLine("--- Adicionando valores ao orçamento ---\n");

// Adicionando valores - todos os observadores serão notificados
orcamento.AdicionarValor(300m);
Console.WriteLine();

orcamento.AdicionarValor(250m);
Console.WriteLine();

orcamento.AdicionarValor(400m);
Console.WriteLine();

orcamento.AplicarDesconto(150m);
