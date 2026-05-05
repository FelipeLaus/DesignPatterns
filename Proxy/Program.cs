using Proxy;
using Proxy.Impostos;

var orcamento = new Orcamento { Valor = 2000m, Itens = 4 };

ICalculadoraImposto calculadora = new ProxyCalculadoraImposto();

Console.WriteLine("Primeira chamada:");
Console.WriteLine($"Imposto: R$ {calculadora.Calcular(orcamento):F2}");

Console.WriteLine("\nSegunda chamada:");
Console.WriteLine($"Imposto: R$ {calculadora.Calcular(orcamento):F2}");
