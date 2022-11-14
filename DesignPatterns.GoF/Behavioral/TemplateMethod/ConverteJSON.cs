using DesignPatterns.GoF.Behavioral.TemplateMethod.AbstractModel;
using DesignPatterns.GoF.Behavioral.TemplateMethod.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.TemplateMethod
{
    public class ConverteJSON : ProcessaDados
    {
        public ConverteJSON(string json) : base(json:json)
        {
        }

        public override void ProcessarJSON()
        {
            this.pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(this.json);
            this.ApresentarValores();
        }

    }
}
