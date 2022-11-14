using DesignPatterns.GoF.Behavioral.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Behavioral.Iterator
{
    public class Iterator : IIterator
    {
        private IAgggregate _agggregate;
        private int _position;

        public Iterator(IAgggregate agggregate, int position = 0)
        {
            _agggregate = agggregate;
            _position = position;
        }

        public string Next
        {
            get
            {
                return _agggregate[_position++];
            }
        }


        public bool HasNext 
        {
            get
            {
                return _position <= _agggregate.Limit;
            }
        }
    }
}
