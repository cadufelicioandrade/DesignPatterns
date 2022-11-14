using DesignPatterns.GoF.Behavioral.Observer.Interfaces;
using DesignPatterns.GoF.Behavioral.Observer.Model;
using DesignPatterns.GoF.Behavioral.Observer.Obervers;
using DesignPatterns.GoF.Behavioral.Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Observer
{
    public class SendMail
    {
        public void EnviarEmail()
        {
            string nsgNaoAssinante = $"Notamos que ainda não faz parte da maior e melhor plataforma de séries e filmes, não fique de fora da promoções de {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} e acesse não plataforma para ver os mais recentes lançamentos.";

            string msgAssinante = $"Lançamentos para o mês {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)} direto do cinema para sua tela.";

            List<IObservavel> observaveis = new List<IObservavel>()
            {
                new NaoAssinante(new Pessoa(1,"José", "jose@gmail.com"), nsgNaoAssinante),
                new NaoAssinante(new Pessoa(2,"Maria", "maria@gmail.com"), nsgNaoAssinante),
                new Assinante(new Pessoa(3,"João", "joao@gmail.com"), msgAssinante),
                new Assinante(new Pessoa(4,"Marta", "marta@gmail.com"), msgAssinante),
            };

            PrimeVideos primeVideos = new PrimeVideos();

            foreach (var o in observaveis)
            {
                primeVideos.AddObservavel(o);
            }

            primeVideos.NotificarObservavel();
        }
    }
}
