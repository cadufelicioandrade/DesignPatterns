using DesignPatterns.GoF.Behavioral.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.State.Estados
{
    public class EstadoA : IEstado
    {
        public void Acao(Context context)
        {
            Console.WriteLine("Executando ações do Estado A");
            context.Estado = new EstadoB();
        }
    }
}
