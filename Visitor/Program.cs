using Visitor;
using Visitor.Itens;
using Visitor.Visitantes;

var itens = new List<IVisitavel>
{
    new ItemProduto("Notebook", 3500m),
    new ItemServico("Consultoria", 1200m, 8),
    new ItemProduto("Mouse", 150m),
};

var calculadora = new CalculadoraImpostoVisitor();
var relatorio = new RelatorioVisitor();

foreach (var item in itens)
{
    item.Aceitar(calculadora);
    item.Aceitar(relatorio);
}

Console.WriteLine(relatorio.GerarRelatorio());
Console.WriteLine($"Total de impostos: R$ {calculadora.TotalImpostos:F2}");
