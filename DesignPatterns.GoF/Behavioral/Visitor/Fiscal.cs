using DesignPatterns.GoF.Behavioral.Visitor.Interfaces;
using DesignPatterns.GoF.Behavioral.Visitor.Produtos;
using DesignPatterns.GoF.Behavioral.Visitor.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Visitor
{
    public class Fiscal
    {
        public void CalcularImpostos()
        {
            CalcularProdutosPereciveis();
            Console.WriteLine(new String('-', 40));
            CalcularProdutosNaoPereciveis();
        }

        private static void CalcularProdutosPereciveis()
        {
            List<ProdutoPerecivel> produtoPerecivels = new List<ProdutoPerecivel>()
            {
                new ProdutoPerecivel("Especiarias", 2500),
                new ProdutoPerecivel("Polpas de frutas", 2000)
            };

            Console.WriteLine("\nCáculando imposto produtos perecíveis:\n");

            foreach (var pp in produtoPerecivels)
            {
                Console.WriteLine($"Produto: {pp.Nome}\nPeso: {pp.Peso}");

                foreach (var visitor in GetVisitors())
                {
                    visitor.CalcularImpostoProdutoPerecivel(pp);
                }
                Console.WriteLine();
            }
        }

        private static void CalcularProdutosNaoPereciveis()
        {
            List<ProdutoNaoPerecivel> produtoNaoPerecivels = new List<ProdutoNaoPerecivel>()
            {
                new ProdutoNaoPerecivel("Antena wifi", 500),
                new ProdutoNaoPerecivel("Perfume Françes", 1000)
            };

            Console.WriteLine("\nCáculando imposto produtos NÃO perecíveis:\n");

            foreach (var pnp in produtoNaoPerecivels)
            {
                Console.WriteLine($"Produto: {pnp.Nome}\nPeso: {pnp.Peso}");

                foreach (var visitor in GetVisitors())
                {
                    visitor.CalcularImpostoProdutoNaoPerecivel(pnp);
                }
                Console.WriteLine();
            }
        }

        private static List<IVisitor> GetVisitors() => new List<IVisitor>()
        {
            new RioDeJaneiroVisitor(), new SaoPauloVisitor()
        };

    }
}
