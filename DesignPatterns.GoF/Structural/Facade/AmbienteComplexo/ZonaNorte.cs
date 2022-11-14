using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Facade.AmbienteComplexo
{
    public class ZonaNorte
    {
        public List<object> ExecutarRotinaVendasPerdidas(DateTime periodo)
        {
            //Executa store procedure para itens de vendas perdidas região Norte MySQL
            Console.WriteLine("[!] - Executando complexidade rotina vendas perdidas região Norte");

            return new List<object>();
        }
    }
}
