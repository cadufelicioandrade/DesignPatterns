using DesignPatterns.GoF.Behavioral.Strategy.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Strategy.Model
{
    public class Orcamento
    {
        public Orcamento(int idCliente, 
                        double valorDiaria, 
                        int quantidade, 
                        PorcentagemServicos porcentagem,
                        bool cupomDesconto = false)
        {
            IdCliente = idCliente;
            ValorDiaria = valorDiaria;
            Quantidade = quantidade;
            CupomDesconto = cupomDesconto;
            Porcentagem = porcentagem;
            CalcularValorTotal();
        }

        public int IdCliente { get; set; }
        public double ValorDiaria { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public bool CupomDesconto { get; set; }
        public PorcentagemServicos Porcentagem { get; set; }

        private void CalcularValorTotal()
        {
            this.ValorTotal = this.Quantidade * this.ValorDiaria;
        }

    }
}
