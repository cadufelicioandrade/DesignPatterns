using DesignPatterns.GoF.Creationals.Builder.Builders;
using DesignPatterns.GoF.Creationals.Builder.Studios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creationals.Builder
{
    public class Client
    {
        
        public void ConsumirDados()
        {
            Director director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.ContruirStudio(studioBuilder); 
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "24m2");

            studioBuilder = new Studio26mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "26m2");

            studioBuilder = new Studio28mBuilder();
            director.ContruirStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
            ImprimirResultado(studio, "28m2");

        }

        private void ImprimirResultado(Studio studio, string nome)
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"[+] - Studio {nome}");
            Console.WriteLine("Valor: {0}\nPiso: {1}\nValor: {2}", studio.ValorStudio.ToString("C"), studio.TipoPiso, studio.TipoFinaciamento);
        }
    }
}
