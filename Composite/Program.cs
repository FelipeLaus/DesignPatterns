using Composite.Itens;

var hardware = new GrupoItens("Hardware");
hardware.Adicionar(new ItemSimples("Notebook", 3500m));
hardware.Adicionar(new ItemSimples("Mouse", 150m));
hardware.Adicionar(new ItemSimples("Teclado", 200m));

var servicos = new GrupoItens("Serviços");
servicos.Adicionar(new ItemSimples("Instalação", 300m));
servicos.Adicionar(new ItemSimples("Suporte mensal", 500m));

var orcamento = new GrupoItens("Orçamento Total");
orcamento.Adicionar(hardware);
orcamento.Adicionar(servicos);

orcamento.Exibir();
Console.WriteLine($"\nTotal: R$ {orcamento.Calcular():F2}");
