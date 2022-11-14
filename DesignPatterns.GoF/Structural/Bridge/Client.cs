using DesignPatterns.GoF.Structural.Bridge.Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Bridge
{
    public class Client
    {
        public IMaterial Material { get; set; }

        public void ConsutarCanetasPinceisEstoque()
        {
            Console.WriteLine(this.Material.ConsultarNoEstoque());
        }

    }
}
