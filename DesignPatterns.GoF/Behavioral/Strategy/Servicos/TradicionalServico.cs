﻿using DesignPatterns.GoF.Behavioral.Strategy.Interfaces;
using DesignPatterns.GoF.Behavioral.Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Strategy.Servicos
{
    public class TradicionalServico : IServico
    {
        private Orcamento _orcamento;

        public TradicionalServico(Orcamento orcamento)
        {
            _orcamento = orcamento;
        }

        public void CalcularServico()
        {
            var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
            _orcamento.ValorTotal += porcentagem;

            if (_orcamento.CupomDesconto)
            {
                Console.WriteLine($"\nValor sem desconto: {_orcamento.ValorTotal.ToString("C")}");
                _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.01;
                Console.WriteLine($"Cupom de desconto de 1% para quarto tradicional.\n");
            }

            Console.WriteLine($"Tipo Quarto: {_orcamento.Porcentagem}\nPorcentagem Serviço: {porcentagem.ToString("C")}\nQuant. Dias: {_orcamento.Quantidade}\nValor Dia: {_orcamento.ValorDiaria}\n Valor Total: {_orcamento.ValorTotal}");
        }
    }
}
