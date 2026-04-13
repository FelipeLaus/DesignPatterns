using Strategy.Impostos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CalculadoraDeImpostos
    {
        public float Calcular(Orcamento orcamento, Imposto imposto)
        {
               float valor = imposto.CalculaImposto(orcamento);
               return valor;
        }
    }
}
