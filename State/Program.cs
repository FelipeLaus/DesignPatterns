using State;

// Criando um orçamento que começa em aprovação
Orcamento orcamento = new Orcamento { Valor = 1000f, Itens = 5 };

Console.WriteLine($"Valor inicial: {orcamento.Valor}");
Console.WriteLine($"Estado: {orcamento.Estado.GetType().Name}");
Console.WriteLine($"Desconto extra: {orcamento.CalculaDescontoExtra()}");

// Aplicando desconto extra
orcamento.AplicaDescontoExtra();
Console.WriteLine($"Valor após desconto: {orcamento.Valor}");

Console.WriteLine("\n--- Aprovando o orçamento ---");
orcamento.Aprovar();
Console.WriteLine($"Estado: {orcamento.Estado.GetType().Name}");
Console.WriteLine($"Desconto extra: {orcamento.CalculaDescontoExtra()}");

// Aplicando desconto extra no estado aprovado
orcamento.AplicaDescontoExtra();
Console.WriteLine($"Valor após desconto: {orcamento.Valor}");

Console.WriteLine("\n--- Finalizando o orçamento ---");
orcamento.Finalizar();
Console.WriteLine($"Estado: {orcamento.Estado.GetType().Name}");

try
{
    orcamento.CalculaDescontoExtra();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao calcular desconto: {ex.Message}");
}

// Testando orçamento reprovado
Console.WriteLine("\n--- Testando orçamento reprovado ---");
Orcamento orcamento2 = new Orcamento { Valor = 500f, Itens = 3 };
orcamento2.Reprovar();
Console.WriteLine($"Estado: {orcamento2.Estado.GetType().Name}");

try
{
    orcamento2.CalculaDescontoExtra();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao calcular desconto: {ex.Message}");
}

