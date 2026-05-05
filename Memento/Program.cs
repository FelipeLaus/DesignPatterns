using Memento;

var orcamento = new Orcamento(1000m, "EmAnalise");
var historico = new HistoricoOrcamento();

Console.WriteLine($"Estado inicial: {orcamento}");

historico.Salvar(orcamento);
orcamento.AlterarValor(1500m);
orcamento.AlterarSituacao("Aprovado");
Console.WriteLine($"Após alteração: {orcamento}");

historico.Salvar(orcamento);
orcamento.AlterarValor(2000m);
orcamento.AlterarSituacao("Finalizado");
Console.WriteLine($"Após segunda alteração: {orcamento}");

historico.Desfazer(orcamento);
Console.WriteLine($"Após desfazer: {orcamento}");

historico.Desfazer(orcamento);
Console.WriteLine($"Após segundo desfazer: {orcamento}");
