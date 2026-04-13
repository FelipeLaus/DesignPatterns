using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Impostos
{
    public class Iss : Imposto
    {
        public float CalculaImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06f;
        }
    }
}
