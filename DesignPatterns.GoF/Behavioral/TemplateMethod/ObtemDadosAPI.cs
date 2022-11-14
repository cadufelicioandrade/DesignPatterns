using DesignPatterns.GoF.Behavioral.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns.GoF.Behavioral.TemplateMethod
{
    public class ObtemDadosAPI
    {
        public static string EndpointXML()
        {
            List<Pessoa> pessoas = GetPessoas();
            XmlSerializer serializer = new XmlSerializer(pessoas.GetType());
            string xml = String.Empty;

            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, pessoas);
                xml = sw.ToString();
            }

            return xml;
        }

        public static string EndpointJSON()
        {
            List<Pessoa> pessoas = GetPessoas();
            var json = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            return json;
        }

        private static List<Pessoa> GetPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa()
                {
                    Nome="José",
                    CPF = "234.445.221-09",
                    Acoes = new List<Acoes>()
                    {
                        new Acoes("AAAA3", 50, 15.44),
                        new Acoes("BBBB4", 80, 22.34)
                    }
                },
                new Pessoa()
                {
                    Nome="Magali",
                    CPF = "345.556.111-10",
                    Acoes = new List<Acoes>()
                    {
                        new Acoes("GGGG6", 50, 15.44),
                        new Acoes("TRRR3", 80, 22.34)
                    }
                },
            };
        }

    }
}
