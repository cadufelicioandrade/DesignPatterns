﻿
using CursoDesignPatternsDesignPatterns.GoF.Behavioral.Receivers;
using DesignPatterns.GoF.Behavioral.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.ChainOfResponsability
{
    public class Sender
    {
        public void RealizarCheckOut()
        {
            Checkout checkout = new Checkout(1001, 20, 23.50);

            Console.WriteLine($"\nAntes:\nValor total checkout: {checkout.ValorTotal.ToString("C")}");
            Console.WriteLine(new String('-', 40));

            var deLavanderia = new ServicoDeLavanderiaReceiver();
            var deQuarto = new ServicoDeQuartoReceiver();
            var deLimpeza = new ServicoLimpezaReceiver();

            deLavanderia.AddNext(deQuarto);
            deQuarto.AddNext(deLimpeza);

            deLavanderia.ExecutarCobrancaServico(checkout);

            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"\nDespois:\nValor total checkout: {checkout.ValorTotal.ToString("C")}");
        }

    }
}
