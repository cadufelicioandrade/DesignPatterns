using DesignPatterns.GoF.Structural.Composite.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Composite
{
    public class Client
    {
        public void EfetuarCompra()
        {
            ComponentModel product01 = new ProductLeaf("Caneca Batman", 25.00);
            ComponentModel product02 = new ProductLeaf("Camiseta Star War", 80.00);
            ComponentModel product03 = new ProductLeaf("Chaveiro Vingadores", 10.00);
            ComponentModel product04 = new ProductLeaf("Estátua Thanos", 500.00);

            ComponentModel smallBox = new ProductComposite();

            smallBox.Add(product01, product02, product03);

            ComponentModel BiggerBox = new ProductComposite();
            BiggerBox.Add(product04, smallBox);

            var total = BiggerBox.Operation();



            Console.WriteLine($"\nValor Total: {total.ToString("C")}");
        }
    }
}
