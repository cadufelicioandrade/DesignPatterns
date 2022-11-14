using DesignPatterns.GoF.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.FactoryMethod.Servicos
{
    public class MasterServico : IServico
    {
        public MasterServico()
        {
            Console.WriteLine("Serviço Master implementado.");
        }

        public void CalcularOrcamento()
        {
            throw new NotImplementedException();
        }
    }
}
