using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Facade.AmbienteComplexo
{
    public class CloudComputing
    {
        public void GerarRelatorioPerdasGanhos(List<object> sul, List<object> norte)
        {
            //Executar cruzamento de itens vendios salvos na nuvem com dados das lojas das
            //regiões Sul e Norte.

            Console.WriteLine("Geração e apresentação do consolidado mensal de perdas e ganhos");
        }
    }
}
