using DesignPatterns.GoF.Structural.Bridge.Implementacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Bridge.Implementacao
{
    public class Preto : ICor
    {
        public string ConsultarQuantidadePorCor()
        {
            // IMPLEMENTA A COMPLEXIDADE PARA CONSULTAR NO BANCO DE DAODS
            var random = new Random();
            var quantidade = random.Next(100, 500);
            return $"Existem {quantidade} Caneta Esferográfica marcador da cor PRETA em estoque.";
        }
    }
}
