using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Composite.AbstractModel
{
    public abstract class ComponentModel
    {

        public abstract double Operation();
        public abstract void Add(params ComponentModel[] component);
        public abstract void Remove(ComponentModel component);
        public abstract ComponentModel GetChild(int index);
    }
}
