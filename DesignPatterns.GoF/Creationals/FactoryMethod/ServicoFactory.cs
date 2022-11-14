using DesignPatterns.GoF.FactoryMethod.Enums;
using DesignPatterns.GoF.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico GetServico(eTiposServicos tiposServico);

    }
}
