using DesignPatterns.GoF.Behavioral.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.GoF.Behavioral.Interpreter.Jumanji.MooseFinbar.PontosFracos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Interpreter.Jumanji
{
    public class ApresentaPopup
    {
        public void ApresentarHabilidadesPopup()
        {
            List<IPontoForte> pontosFortes = new List<IPontoForte>()
            {
                new Armeiro(), new Zoologia()
            };

            List<IPontoFraco> pontosFracos = new List<IPontoFraco>()
            {
                new Bolo(), new Forca(), new Velocidade()
            };

            var mooseFinbar = new Contexto("Moose Finbar");

            Habilidades habilidades = new Habilidades(pontosFortes, pontosFracos);
            habilidades.Interpretar(mooseFinbar);

        }

    }
}
