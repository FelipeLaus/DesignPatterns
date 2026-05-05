using Interpreter;
using Interpreter.Expressoes;

var contexto = new Contexto(2000m);

// Expressão: desconto de 10% + frete grátis (R$ 50)
IExpressao expressao = new SomaExpressao(
    new DescontoExpressao(10),
    new FreteGratisExpressao(50m)
);

var totalBeneficio = expressao.Interpretar(contexto);

Console.WriteLine($"Valor do orçamento: R$ {contexto.ValorOrcamento:F2}");
Console.WriteLine($"Total de benefícios: R$ {totalBeneficio:F2}");
Console.WriteLine($"Frete grátis aplicado: {contexto.FreteGratis}");
Console.WriteLine($"Valor final: R$ {contexto.ValorOrcamento - totalBeneficio:F2}");
