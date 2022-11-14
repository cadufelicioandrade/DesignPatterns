using DesignPatterns.GoF.Behavioral.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Command
{
    public class ControleInvoker
    {
        private Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();

        public void AddCommand(string key, ICommand command)
        {
            this.Commands.Add(key, command);
        }

        public void ExecuteCommand(string key)
        {
            if (!this.Commands.Keys.Contains(key))
            {
                Console.WriteLine("Comando inexistente");
            }
            else
            {
                this.Commands[key].Execute();
            }

        }

    }
}
