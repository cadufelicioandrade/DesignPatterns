using DesignPatterns.GoF.Behavioral.TemplateMethod.AbstractModel;
using DesignPatterns.GoF.Behavioral.TemplateMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.GoF.Behavioral.TemplateMethod
{
    public class ConverteXML : ProcessaDados
    {
        public ConverteXML(string xml) : base(xml:xml)
        {
        }

        public override void ProcessarXML()
        {
            XmlSerializer serializer = new XmlSerializer(this.pessoas.GetType());
            
            var stringReader = new StringReader(this.xml);

            using (var reader = XmlReader.Create(stringReader))
            {
                this.pessoas = (List<Pessoa>)serializer.Deserialize(reader);
            }

            this.ApresentarValores();
        }


    }
}
