using DesignPatterns.GoF.Behavioral.Visitor.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Visitor.Interfaces
{
    public interface IVisitor
    {
        //Visita um produto e aplica a regra de calcular o imposto
        double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel);
        double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel);
    }
}
