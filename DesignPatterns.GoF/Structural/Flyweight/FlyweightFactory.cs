using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GoF.Structural.Flyweight.AbstractModel;
using DesignPatterns.GoF.Structural.Flyweight.Flyweights;

namespace DesignPatterns.GoF.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, EspacoNave> nave_lista = new Dictionary<string, EspacoNave>();

        public EspacoNave GetEspacoNave(string cor)
        {
            EspacoNave nave = null;

            if (nave_lista.ContainsKey(cor))
            {
                nave = nave_lista[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        nave = new Azul();
                        break;
                    case "cinza":
                        nave = new Cinza();
                        break;
                    case "vermelha":
                        nave = new Vermelha();
                        break;
                    default:
                        break;
                }

                nave_lista.Add(cor, nave);
            }

            return nave;
        }
    }
}
