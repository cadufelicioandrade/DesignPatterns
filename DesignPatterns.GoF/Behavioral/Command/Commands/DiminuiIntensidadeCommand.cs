using DesignPatterns.GoF.Behavioral.Command.Interfaces;
using DesignPatterns.GoF.Behavioral.Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Command.Commands
{
    public class DiminuiIntensidadeCommand : ICommand
    {
        private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

        public DiminuiIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
        {
            _luzLuminariaReceiver = luzLuminariaReceiver;
        }

        public void Execute()
        {
            _luzLuminariaReceiver.DiminuirIntensidade();
        }
    }
}
