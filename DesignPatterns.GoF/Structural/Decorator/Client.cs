using DesignPatterns.GoF.Structural.Decorator.Decorators;
using DesignPatterns.GoF.Structural.Decorator.Interfaces;
using DesignPatterns.GoF.Structural.Decorator.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Decorator
{
    public class Client
    {
        public void ConsumirServico()
        {
            IPet banhoTosa = new BanhoTosa("Banho e Tosa", 45.00);
            
            //Imita a class banhoTosa
            IPet acessorioDecorator = new AcessorioDecorator(banhoTosa);
            IPet luxoSpa = new LuxoSpaDecorator(acessorioDecorator);


            Console.WriteLine(banhoTosa.GetValorServico());
            Console.WriteLine(acessorioDecorator.GetValorServico());
            Console.WriteLine(luxoSpa.GetValorServico());

            Console.WriteLine(luxoSpa.GetNomeServico());
        }
    }
}
