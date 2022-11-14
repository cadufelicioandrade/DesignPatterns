using DesignPatterns.GoF.Creationals.AbstractFactory.Factories.Interfaces;
using DesignPatterns.GoF.Creationals.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.AbstractFactory.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            this.CriarRotinaDiaria();
        }

        public void CriarRotinaDiaria()
        {
            Console.WriteLine("Factory Terça e Sexta Criada");
            TreinoTercaSexta treino = new TreinoTercaSexta();
            DietaTercaSexta dieta = new DietaTercaSexta();

            treino.ObterTreino();
            dieta.ObterAlimentacao();

        }
    }
}
