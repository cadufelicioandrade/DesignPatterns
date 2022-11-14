using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Observer.Interfaces
{
    public interface ISujeito
    {
        List<IObservavel> Observaveis { get; set; }
        void AddObservavel(IObservavel observavel);
        void RemoveObservavel(IObservavel observavel);
        void NotificarObservavel();
    }
}
