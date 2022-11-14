using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Facade.AmbienteComplexo
{
    public class ZonaSul
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            //Executa store procedure para itens vendas perdidas e regras de negõcio SQL Server
            Console.WriteLine("[!] - Executando complexidade rotina vendas perdidas região Sul");

            return new List<object>();
        }
    }
}
