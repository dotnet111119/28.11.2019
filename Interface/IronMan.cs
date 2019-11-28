using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811int
{
    public class IronMan : SuperHeroBase
    {
        public IronMan(string name) : base(name)
        {
        }

        public override void ActivateSuperPowers()
        {
            Console.WriteLine("Fly and fire rockets!");
        }

        // activeate super powers
    }
}
