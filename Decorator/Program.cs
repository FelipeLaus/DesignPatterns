using Decorator;
using Decorator.Descontos;

var orcamento = new Orcamento { Valor = 2000m, Itens = 4 };

ICalculadoraDesconto calculadora = new CalculadoraBase();
calculadora = new DescontoVip(calculadora);
calculadora = new DescontoCupom(calculadora, 100m);
calculadora = new DescontoFidelidade(calculadora);

var totalDesconto = calculadora.Calcular(orcamento);

Console.WriteLine($"Valor original: R$ {orcamento.Valor:F2}");
Console.WriteLine($"Total de desconto: R$ {totalDesconto:F2}");
Console.WriteLine($"Valor final: R$ {orcamento.Valor - totalDesconto:F2}");
