using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Iterator.Interfaces
{
    public interface IAgggregate
    {
        IIterator GetIterator();
        string this[int index] { set; get; }
        public int Limit { get; }
    }
}
