using Strategy;
using Strategy.Impostos;

CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

Orcamento orcamento = new Orcamento { Valor = 500f };

float valor = calculadora.Calcular(orcamento, new Icms());
Console.WriteLine(valor);

valor = calculadora.Calcular(orcamento, new Iss());
Console.WriteLine(valor);