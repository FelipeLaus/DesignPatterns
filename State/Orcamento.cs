using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Orcamento
    {
        public float Valor { get; set; }
        public int Itens { get; set; }
        public EstadoOrcamento Estado { get; set; }

        public Orcamento()
        {
            Estado = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            this.Valor -= this.CalculaDescontoExtra();
        }

        public float CalculaDescontoExtra()
        {
            return Estado.CalculaDescontoExtra(this);
        }

        public void Aprovar()
        {
            Estado.Aprovar(this);
        }

        public void Reprovar()
        {
            Estado.Reprovar(this);
        }

        public void Finalizar()
        {
            Estado.Finalizar(this);
        }
    }
}
