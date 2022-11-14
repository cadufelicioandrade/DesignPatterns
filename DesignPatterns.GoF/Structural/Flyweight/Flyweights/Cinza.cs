using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GoF.Structural.Flyweight.AbstractModel;

namespace DesignPatterns.GoF.Structural.Flyweight.Flyweights
{
    public class Cinza : EspacoNave
    {
        public Cinza()
        {
            condicao = "Voando em linha reta - ";
            acao = "disparando lasers";
        }

        public override void Mostrar(string cor, string tamanho)
        {
            this.cor = cor;
            this.tamanho = tamanho;
            Console.WriteLine($"Nave {tamanho} e {cor} {condicao} {acao}");
        }
    }
}
