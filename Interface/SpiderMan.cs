using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811int
{
    public class SpiderMan : SuperHeroBase
    {
        public int RemainingWeb { get; private set; }
        public SpiderMan(string name) : base(name)
        {
            RemainingWeb = 100;
        }

        public override void ActivateSuperPowers()
        {
            Console.WriteLine("Fire web!");
        }
    }
}
