using Bridge;
using Bridge.Formatos;
using Bridge.Relatorios;

var orcamento = new Orcamento { Cliente = "Empresa XYZ", Valor = 4500m, Itens = 6 };

Console.WriteLine(new RelatorioResumido(new FormatoTexto()).Gerar(orcamento));
Console.WriteLine();
Console.WriteLine(new RelatorioDetalhado(new FormatoTexto()).Gerar(orcamento));
Console.WriteLine();
Console.WriteLine(new RelatorioResumido(new FormatoCsv()).Gerar(orcamento));
