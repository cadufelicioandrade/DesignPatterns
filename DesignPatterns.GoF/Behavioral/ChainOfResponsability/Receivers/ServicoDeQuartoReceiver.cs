
using DesignPatterns.GoF.Behavioral.AbstractModel;
using DesignPatterns.GoF.Behavioral.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatternsDesignPatterns.GoF.Behavioral.Receivers
{
    public class ServicoDeQuartoReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança de taxa dos serviços de quarto...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.03);

            return base.ExecutarCobrancaServico(checkout);
        }

    }
}
