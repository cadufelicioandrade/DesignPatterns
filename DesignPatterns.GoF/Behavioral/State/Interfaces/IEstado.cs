using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.State.Interfaces
{
    public interface IEstado
    {
        public void Acao(Context context);
    }
}
