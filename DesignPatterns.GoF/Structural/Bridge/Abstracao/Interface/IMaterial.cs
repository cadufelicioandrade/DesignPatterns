using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GoF.Structural.Bridge.Implementacao.Interfaces;

namespace DesignPatterns.GoF.Structural.Bridge.Abstracao.Interfaces
{
    public interface IMaterial
    {
        string ConsultarNoEstoque();
        ICor Icor { get; set; }

    }
}
