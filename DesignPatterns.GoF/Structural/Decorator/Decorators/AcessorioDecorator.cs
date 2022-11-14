using DesignPatterns.GoF.Structural.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Decorator.Decorators
{
    public class AcessorioDecorator : PetDecorator
    {
        public AcessorioDecorator(IPet pet) : base(pet)
        {
        }

        public override double GetValorServico()
        {
            return this._pet.GetValorServico() + 30.00;
        }

        public override string GetNomeServico()
        {
            return this._pet.GetNomeServico() + "\n[+] Acessório";
        }
    }
}
