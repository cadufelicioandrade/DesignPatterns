using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.Builder.Studios
{
    public abstract class Studio
    {
        public string TipoPiso { get; protected set; }
        public string TipoFinaciamento { get; protected set; }
        public decimal ValorStudio { get; protected set; }

        public abstract void EscolherPiso(string piso);
        public abstract void EscolherFinaciamento(string financiamento);
        public abstract void DefinirValorStudio(decimal valor);
        
    }
}
