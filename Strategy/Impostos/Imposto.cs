using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Impostos
{
    public interface Imposto
    {
        public float CalculaImposto(Orcamento orcamento);
    }
}
