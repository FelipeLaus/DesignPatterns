using Adapter;
using Adapter.Pagamentos;

var orcamento = new Orcamento { Valor = 1500m, Itens = 3 };

IProcessadorPagamento processador = new ProcessadorPagamentoAdapter(new ProcessadorPagamentoAntigo());
processador.ProcessarPagamento(orcamento);
