using Flyweight;

var fabrica = new FabricaTipoItem();

var itens = new List<ItemOrcamento>
{
    new(fabrica.Obter("Notebook", "Hardware", "un"), 2, 3500m),
    new(fabrica.Obter("Notebook", "Hardware", "un"), 1, 3500m),
    new(fabrica.Obter("Mouse", "Hardware", "un"), 5, 150m),
    new(fabrica.Obter("Consultoria", "Serviço", "h"), 10, 200m),
    new(fabrica.Obter("Consultoria", "Serviço", "h"), 8, 200m),
};

Console.WriteLine();
foreach (var item in itens)
    Console.WriteLine(item);

Console.WriteLine($"\nTotal de tipos únicos criados: {fabrica.TotalTiposCriados}");
Console.WriteLine($"Total de itens no orçamento: {itens.Count}");
Console.WriteLine($"Valor total: R$ {itens.Sum(i => i.Calcular()):F2}");
