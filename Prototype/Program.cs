using Prototype;

var modelo = new Orcamento
{
    Cliente = "Template",
    Valor = 1000m,
    Itens = new() { "Notebook", "Mouse" },
    Tipo = "Padrão"
};

var orcamento1 = modelo.Clonar();
orcamento1.Cliente = "Empresa ABC";
orcamento1.Itens.Add("Teclado");

var orcamento2 = modelo.Clonar();
orcamento2.Cliente = "Empresa XYZ";
orcamento2.Valor = 1500m;

Console.WriteLine("=== Modelo Original ===");
Console.WriteLine(modelo);

Console.WriteLine("\n=== Orçamento 1 (clonado + modificado) ===");
Console.WriteLine(orcamento1);

Console.WriteLine("\n=== Orçamento 2 (clonado + modificado) ===");
Console.WriteLine(orcamento2);
