using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motherload
{
    class Element
    {
        protected int _storage;
        protected int _value;
        protected int _id;
        //default constructor
        public Element() 
        {
            _storage = 0;
            _value = 0;
            _id = 0;
        }
        //constructor
        public Element(int storage, int value, int id)
        {
            _storage = storage;
            _value = value;
            _id = id;
        }


    }
}
