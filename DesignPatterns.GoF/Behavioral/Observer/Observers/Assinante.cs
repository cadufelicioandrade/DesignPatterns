using DesignPatterns.GoF.Behavioral.Observer.Interfaces;
using DesignPatterns.GoF.Behavioral.Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Observer.Obervers
{
    public class Assinante : IObservavel
    {
        public Assinante(Pessoa pessoa, string mensagem)
        {
            Pessoa = pessoa;
            Mensagem = mensagem;
        }

        public Pessoa Pessoa { get; set; }
        public string Mensagem { get; set; }

        public void Update()
        {
            //Simular envio de email para assinte
            Console.WriteLine($"Enviadno e-mail para: {Pessoa.Email}\n");
            Console.WriteLine($"Prezado {Pessoa.Nome}\n{Mensagem}");

            Console.WriteLine($"\nINSERT INTO TB_NOFICACAO (PessoaId, Notifica, Mes) VALUES ({Pessoa.Id}, 1, {DateTime.Now.Month})\n");

        }
    }
}
