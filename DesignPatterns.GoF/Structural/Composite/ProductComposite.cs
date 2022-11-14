using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GoF.Structural.Composite.AbstractModel;

namespace DesignPatterns.GoF.Structural.Composite
{
    public class ProductComposite : ComponentModel
    {
        private List<ComponentModel> components = new List<ComponentModel>();

        public override void Add(params ComponentModel[] component)
        {
            components.AddRange(component);
        }

        public override ComponentModel GetChild(int index)
        {
            if(components.Count == 0)
            {
                Console.WriteLine("Não possuem produtos cadastrados");
                return null;
            }

            return components[index];
        }

        public override double Operation()
        {
            double total = 0;

            this.components.ForEach(c =>
            {
                total += c.Operation();
            });

            return total;
        }

        public override void Remove(ComponentModel component)
        { 
            components.Remove(component);
        }
    }
}
