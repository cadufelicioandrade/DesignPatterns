using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behaviorall.Memento
{
    public class Videocassete
    {
        public void ExecutarAcaoVideo()
        {
            Originator originator = new Originator();
            originator.Estado = "play";

            Caretaker caretaker = new Caretaker();
            caretaker.AddSnapshot(originator.CreateSnapshot());

            originator.Estado = "pause";

            originator.Restore(caretaker.GetSnapshot());

        }
    }
}
