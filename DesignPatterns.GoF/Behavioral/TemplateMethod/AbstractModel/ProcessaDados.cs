using DesignPatterns.GoF.Behavioral.TemplateMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.TemplateMethod.AbstractModel
{
    public abstract class ProcessaDados
    {
        protected List<Pessoa> pessoas;
        protected string json;
        protected string xml;

        public ProcessaDados(string xml="", string json="")
        {
            if(!String.IsNullOrEmpty(xml))
                this.xml = xml;
            else if(!String.IsNullOrEmpty(json))
                this.json = json;

            this.pessoas = new List<Pessoa>();
        }

        public virtual void ProcessarXML() { }
        public virtual void ProcessarJSON() { }


        protected void ApresentarValores()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(new String('#', 40));

                Console.WriteLine($"Cliente: {pessoa.Nome}\n");
                double valorTotal = 0;

                foreach (var acao in pessoa.Acoes)
                {
                    Console.WriteLine(new String('-', 30));
                    valorTotal += acao.ValorUnitario * acao.Quantidade;
                    Console.WriteLine($"Sigla: {acao.Sigla}\nValor unitário: {acao.ValorUnitario.ToString("C")}\nQuantidade: {acao.Quantidade}\nValor total: {valorTotal.ToString("C")}");
                }
            }
        }

    }
}
