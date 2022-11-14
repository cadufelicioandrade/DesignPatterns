using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GoF.Structural.Composite.AbstractModel;

namespace DesignPatterns.GoF.Structural.Composite
{
    public class ProductLeaf : ComponentModel
    {
        private double valor;
        private string name;
        

        public ProductLeaf(string name, double valor)
        {
            this.valor = valor;
            this.name = name;
        }

        public override void Add(params ComponentModel[] component)
        {
            Console.WriteLine("Não é possível adicionar itens em um objeto do tipo Leaf");
        }

        public override ComponentModel GetChild(int index)
        {
            throw new NullReferenceException("Não é possível obter itens em um objeto do tipo Leaf");
        }

        public override double Operation()
        {
            Console.WriteLine($"Produto: {this.name}\nValor: {this.valor.ToString("C")}");
            Console.WriteLine(new String('-', 40));
            return this.valor;
        }

        public override void Remove(ComponentModel component)
        {
            Console.WriteLine("Não é possível remover itens em um objeto do tipo Leaf");
        }
    }
}
