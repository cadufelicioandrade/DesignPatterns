using DesignPatterns.GoF.Behavioral.Visitor.Interfaces;
using DesignPatterns.GoF.Behavioral.Visitor.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Visitor.Visitors
{
    public class RioDeJaneiroVisitor : IVisitor
    {
        public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
        {
            var imposto = (produtoNaoPerecivel.Peso / 100) + 5;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }

        public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
        {
            var imposto = (produtoPerecivel.Peso / 100) + 10;

            Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

            return imposto;
        }
    }
}
