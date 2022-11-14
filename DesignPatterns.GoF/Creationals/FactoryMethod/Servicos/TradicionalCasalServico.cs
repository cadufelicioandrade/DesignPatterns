using DesignPatterns.GoF.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.FactoryMethod.Servicos
{
    public class TradicionalCasalServico : IServico
    {
        public TradicionalCasalServico()
        {
            Console.WriteLine("Serviço Tradicional Casal implementado.");
        }

        public void CalcularOrcamento()
        {
            throw new NotImplementedException();
        }
    }
}
