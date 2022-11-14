﻿using DesignPatterns.GoF.Creationals.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.AbstractFactory.Products
{
    public class TreinoTercaSexta : ITreino
    {
        public void ObterTreino()
        {
            Console.WriteLine("Ficha de treino de Terça e Sexta");
        }
    }
}
