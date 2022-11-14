using DesignPatterns.GoF.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Adapter
{
    public class BusinessLegado 
    {
        
        public string ExecutarRotinaContasPagar(string mes)
        {
            var result = ConsultaSQL.GetDadosPagar(mes);

            Console.WriteLine("\n[+] - Processando regras legado contas a pagar");
            //Aplicação de regras de negócio.
            Thread.Sleep(3000);

            return result;
        }

        public string ExecutarRotinaContasReceber(string mes)
        {
            var result = ConsultaSQL.GetDadosReceber(mes);

            Console.WriteLine("\n[+] - Processando regras legado contas a receber");
            //Aplicação de regras de negócio.
            Thread.Sleep(3000);

            return result;
        }
    }

    public class ConsultaSQL
    {
        public static string GetDadosPagar(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("junho", "CNPJ:12324657869342\nRazão social:Lojas Prudente\nValor:1200.00\nContato:(11) 3323-3456");
            dic.Add("julho", "CNPJ:12324657869342\nRazão social:Lojas Prudente\nValor:1200.00\nContato:(11) 3323-3456");
            dic.Add("agosto", "CNPJ:12324657869342\nRazão social:Lojas Prudente\nValor:1200.00\nContato:(11) 3323-3456");
            dic.Add("setembro", "CNPJ:12324657869342\nRazão social:Lojas Prudente\nValor:1200.00\nContato:(11) 3323-3456");

            return dic[mes];
        }

        public static string GetDadosReceber(string mes)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("junho", "CNPJ:12324657869342\nRazão social:Lojas Prudente\nValor:1200.00\nContato:(11) 3323-3456");
            dic.Add("julho", "CNPJ:12324657869342\nRazão social:Lojas Prudente;Valor:1200.00\nContato:(11) 3323-3456");
            dic.Add("agosto", "CNPJ:12324657869342\nRazão social:Lojas Prudente\nValor:1200.00;Contato:(11) 3323-3456");
            dic.Add("setembro", "CNPJ:12324657869342\nRazão social:Lojas Prudente\nValor:1200.00\nContato:(11) 3323-3456");

            return dic[mes];
        }

    }

}
