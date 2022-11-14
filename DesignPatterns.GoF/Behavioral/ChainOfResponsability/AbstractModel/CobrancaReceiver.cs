using DesignPatterns.GoF.Behavioral.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.AbstractModel
{
    public abstract class CobrancaReceiver
    {
        public CobrancaReceiver Next = null;

        public CobrancaReceiver AddNext(CobrancaReceiver next)
        {
            this.Next = next;
            return next;
        }

        public virtual Checkout ExecutarCobrancaServico(Checkout checkout)
        {
            if(this.Next != null)
                return this.Next.ExecutarCobrancaServico(checkout);

            return null;
        }
    }
}
