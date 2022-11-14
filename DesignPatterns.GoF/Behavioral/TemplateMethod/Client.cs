using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.TemplateMethod
{
    public class Client
    {
        public void ConsumirEndpointXML()
        {
            Console.WriteLine("\n____________XML____________\n");

            var xml = ObtemDadosAPI.EndpointXML();
            ConverteXML converteXML = new ConverteXML(xml);

            converteXML.ProcessarXML();
        }

        public void ConsumirEndpointJSON()
        {
            Console.WriteLine("\n____________JSON____________\n");

            var JSON = ObtemDadosAPI.EndpointJSON();
            ConverteJSON convertejson = new ConverteJSON(JSON);

            convertejson.ProcessarJSON();
        }

    }
}
