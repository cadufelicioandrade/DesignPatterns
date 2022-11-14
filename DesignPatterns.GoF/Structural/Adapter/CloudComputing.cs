using DesignPatterns.GoF.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Adapter
{
    public class CloudComputing 
    {
        IAdapter adapter;

        public CloudComputing()
        {
            this.adapter = new Adapter(new BusinessLegado());
        }

        public void ProcessarContas(string mes)
        {
            var result = this.adapter.ExecutarRotinaContasPagar(mes);
            
            Console.WriteLine("[#] - Processando regras Cloud Computing contas a pagar. . .\n");
            Thread.Sleep(3000);
            Console.WriteLine(result);


            Console.WriteLine(new String('-',40));
            
            result = this.adapter.ExecutarRotinaContasReceber(mes);
            
            Console.WriteLine("[#] - Processando regras Cloud Computing contas a receber. . .\n");
            Thread.Sleep(3000);
            Console.WriteLine(result);

            Console.WriteLine("\nProcesso finalizado com sucesso!");
        }

        
    }
}
