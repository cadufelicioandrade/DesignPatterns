using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behaviorall.Memento
{
    public class Caretaker
    {
        private Snapshot _snapshot;

        public void AddSnapshot(Snapshot snapshot)
        {
            _snapshot = snapshot;
        }

        public Snapshot GetSnapshot()
        {
            return _snapshot;
        }
    }
}
