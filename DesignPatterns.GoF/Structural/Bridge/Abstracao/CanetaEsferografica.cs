using DesignPatterns.GoF.Structural.Bridge.Abstracao.Interfaces;
using DesignPatterns.GoF.Structural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Bridge.Abstracao
{
    public class CanetaEsferografica : IMaterial
    {
        public ICor Icor { get; set; }

        public string ConsultarNoEstoque()
        {
            
            return this.Icor.ConsultarQuantidadePorCor();
        }
    }
}
