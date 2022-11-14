using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Structural.Flyweight.AbstractModel
{
    public abstract class EspacoNave
    {
        protected string condicao;
        protected string acao;
        public string cor { get; set; }
        public string tamanho { get; set; }
        public abstract void Mostrar(string cor, string tamanho);

    }
}
