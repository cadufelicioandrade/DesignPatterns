using DesignPatterns.GoF.Creationals.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.AbstractFactory.Products
{
    public class DietaTercaSexta : IDieta
    {
        public void ObterAlimentacao()
        {
            Console.WriteLine("Cardápio de Terça e Sexta.");
        }
    }
}
