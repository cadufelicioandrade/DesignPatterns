using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behaviorall.Memento
{
    public class Originator
    {
        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                Console.WriteLine($"Estado atual do vídeo: {_estado}");
            }
        }

        public Snapshot CreateSnapshot()
        {
            return (new Snapshot(_estado));
        }

        public void Restore(Snapshot snapshot)
        {
            Console.WriteLine("Restaurando estado. . .");
            Estado = snapshot.GetState();
        }

    }
}
