using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace лб._5
{
    class Cat
    {
        private string _name;
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
            get { return _name; }
        }

        private uint _age;
        public uint Age
        {
            get { return _age; }
        }
        public Cat(uint Age)
        {
            _age = Age;
        }
        
        public int Health { set; get; }

        public string Color
        {
            get
            {
                if (Health < 0)
                    return "white";
                if (Health > 0)
                    return "green";
                else
                    return "red";
            }
        }

        public void Feed(int foodCount)
        {
            Health += foodCount;
        }

        public void Punish(int punch)
        {
            Health -= punch;
        }
    }
}
