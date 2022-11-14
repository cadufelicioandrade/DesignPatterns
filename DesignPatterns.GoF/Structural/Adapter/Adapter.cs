using DesignPatterns.GoF.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Adapter
{
    public class Adapter : IAdapter
    {
        BusinessLegado _legado;

        public Adapter(BusinessLegado legado)
        {
            this._legado = legado;
        }

        public string ExecutarRotinaContasPagar(string mes)
        {
            return this._legado.ExecutarRotinaContasPagar(mes);
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            return this._legado.ExecutarRotinaContasReceber(mes);
        }
    }
}
