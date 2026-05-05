using AbstractFactory;
using AbstractFactory.Formal;
using AbstractFactory.Simplificado;

var orcamento = new Orcamento { Cliente = "Empresa XYZ", Valor = 5400m, Itens = 8 };

Console.WriteLine("=== Documento Formal ===");
new GeradorDocumento(new FabricaDocumentoFormal()).Gerar(orcamento);

Console.WriteLine("\n=== Documento Simplificado ===");
new GeradorDocumento(new FabricaDocumentoSimplificado()).Gerar(orcamento);
