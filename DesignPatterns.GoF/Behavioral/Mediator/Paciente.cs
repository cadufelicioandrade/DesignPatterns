using DesignPatterns.GoF.Behavioral.Mediator.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Mediator
{
    public class Paciente : Contato
    {
        public Paciente(Mediador mediador) : base(mediador)
        {
        }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine("Paciente escrevendo...");
            Thread.Sleep(3000);
            this.Mediador.Enviar(mensagem, this);
            Thread.Sleep(3000);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine($"Para Paciente: {mensagem}");
        }

    }
}
