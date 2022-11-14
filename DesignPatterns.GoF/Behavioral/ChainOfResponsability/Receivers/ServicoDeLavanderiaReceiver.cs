using DesignPatterns.GoF.Behavioral.AbstractModel;
using DesignPatterns.GoF.Behavioral.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Receivers
{
    public class ServicoDeLavanderiaReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando cobrança taxa de serviços de lavanderia...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.028);

            return base.ExecutarCobrancaServico(checkout);
        }

    }
}
