using DesignPatterns.GoF.Creationals.AbstractFactory.Factories.Interfaces;
using DesignPatterns.GoF.Creationals.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.AbstractFactory.Factories
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            this.CriarRotinaDiaria();
        }

        public void CriarRotinaDiaria()
        {
            Console.WriteLine("Factory Quarta e Sábado criado");

            TreinoQuartaSabado treino = new TreinoQuartaSabado();
            DietaQuartaSabado dieta = new DietaQuartaSabado();
            treino.ObterTreino();
            dieta.ObterAlimentacao();
        }
    }
}
