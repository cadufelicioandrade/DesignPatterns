using DesignPatterns.GoF.FactoryMethod.Enums;
using DesignPatterns.GoF.FactoryMethod.Interfaces;
using DesignPatterns.GoF.FactoryMethod.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.FactoryMethod
{
    public class ExecutaServico : ServicoFactory
    {
        public override IServico GetServico(eTiposServicos tiposServico)
        {
            switch (tiposServico)
            {
                case eTiposServicos.cobertura:
                    return new CoberturaServico();
                case eTiposServicos.master:
                    return new MasterServico();
                case eTiposServicos.premium:
                    return new PremiumServico();
                case eTiposServicos.casal:
                    return new TradicionalCasalServico();
                case eTiposServicos.solteiro:
                    return new TradicionalSolteiroServico();
                default:
                    return null;
            }
        }
    }
}
