using DesignPatterns.GoF.Structural.Bridge.Abstracao.Interfaces;
using DesignPatterns.GoF.Structural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Bridge.Abstracao
{
    public class PincelMarcador : IMaterial
    {
        public ICor Icor { get; set; }

        public string ConsultarNoEstoque()
        {
            var random = new Random();
            var quantidade = random.Next(100, 500);

            return $"Existem {quantidade} Pincel marcador da cor: {Icor.ConsultarQuantidadePorCor()} em estoque.";
        }
    }
}
