using DesignPatterns.GoF.Creationals.AbstractFactory.Factories.Interfaces;
using DesignPatterns.GoF.Creationals.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.AbstractFactory.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            this.CriarRotinaDiaria();
        }

        public void CriarRotinaDiaria()
        {
            Console.WriteLine("Factory Segunda e Terca criado");

            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();
            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            treino.ObterTreino();
            dieta.ObterAlimentacao();
        }
    }
}
