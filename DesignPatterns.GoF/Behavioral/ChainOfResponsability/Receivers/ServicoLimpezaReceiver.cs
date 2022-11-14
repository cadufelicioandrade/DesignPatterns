
using DesignPatterns.GoF.Behavioral.AbstractModel;
using DesignPatterns.GoF.Behavioral.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Receivers
{
    public class ServicoLimpezaReceiver : CobrancaReceiver
    {
        public override Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            Console.WriteLine("Realizando a cobrança de taxa de serviços de limpeza...");
            checkout.ValorTotal += (checkout.ValorTotal * 0.025);

            return base.ExecutarCobrancaServico(checkout);
        }

    }
}
