using DesignPatterns.GoF.Structural.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Decorator.Servicos
{
    public class BanhoTosa : IPet
    {
        private string _nomeServico;
        private double _valorServico;

        public BanhoTosa(string nomeServico, double valorServico)
        {
            _nomeServico = nomeServico;
            _valorServico = valorServico;
        }

        public string GetNomeServico()
        {
            return _nomeServico;
        }

        public double GetValorServico()
        {
            return _valorServico;
        }
    }
}
