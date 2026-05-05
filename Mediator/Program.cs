using Mediator;
using Mediator.Departamentos;

var mediador = new MediadorPedido();
var financeiro = new DepartamentoFinanceiro();
var estoque = new DepartamentoEstoque();
var expedicao = new DepartamentoExpedicao();

mediador.AdicionarDepartamento(financeiro);
mediador.AdicionarDepartamento(estoque);
mediador.AdicionarDepartamento(expedicao);

financeiro.AprovarPedido();
