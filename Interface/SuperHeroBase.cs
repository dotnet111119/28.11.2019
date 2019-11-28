using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811int
{
    public abstract class SuperHeroBase : ISuperPower
    {
        public string Name { get; private set; }

        protected SuperHeroBase(string name)
        {
            Name = name;
        }

        public abstract void ActivateSuperPowers();
    }
}
