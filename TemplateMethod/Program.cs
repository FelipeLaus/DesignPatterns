using TemplateMethod;

CalculadoraDesconto calculadora = new CalculadoraDesconto();

Orcamento orcamento = new Orcamento { Valor = 600f, Itens = 5 };
float desconto = calculadora.Calcula(orcamento);
Console.WriteLine($"Desconto: {desconto}");