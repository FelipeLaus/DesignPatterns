using Facade;

var orcamento = new Orcamento { Cliente = "Empresa ABC", Valor = 3200m, Itens = 5 };

var fachada = new FachadaPedido();
fachada.FecharPedido(orcamento);
