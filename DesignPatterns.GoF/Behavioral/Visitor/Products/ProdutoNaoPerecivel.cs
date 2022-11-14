﻿using DesignPatterns.GoF.Behavioral.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Visitor.Produtos
{
    public class ProdutoNaoPerecivel : IProduct
    {
        public ProdutoNaoPerecivel(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public string Nome { get; set; }
        public double Peso { get; set; }

        public double GetImposto(IVisitor visitor)
        {
            return visitor.CalcularImpostoProdutoNaoPerecivel(this);
        }
    }
}
