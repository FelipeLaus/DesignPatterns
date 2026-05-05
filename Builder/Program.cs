using Builder;
using Builder.Construtores;

Console.WriteLine("=== Orçamento Completo ===");
var diretor = new DiretorOrcamento(new ConstrutorOrcamentoCompleto());
Console.WriteLine(diretor.ConstruirOrcamentoCorporativo("Empresa ABC"));

Console.WriteLine("\n=== Orçamento Simples ===");
var diretorSimples = new DiretorOrcamento(new ConstrutorOrcamentoSimples());
Console.WriteLine(diretorSimples.ConstruirOrcamentoBasico("João Silva"));
