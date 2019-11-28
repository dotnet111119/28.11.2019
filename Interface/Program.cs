using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811int
{
    class Program
    {
        static void Main(string[] args)
        {

            ISuperPower sp12 = new SpiderMan("Pitter Parker");
            bool sp5 = sp12 is SpiderMan;

            int i1 = 10;
            float f = 10.5f;
            int i2 = (int)f;
            
            //Shape s = new Circle();
            // s is Circle
            //ISuperPower[] 
            SpiderMan spiderMan = new SpiderMan("Spider man");
            //spiderMan.
            FirePowers(spiderMan);
            ActivatePower(new ISuperPower[]{
                            new Joker(),
                            new IronMan("Tony Stark"),
                            new SpiderMan("Pitter Parker")
                            //new StamTenant() -- error!
                        });
            SpiderMan sp = new SpiderMan("Pitter Parker");
            ISuperPower super = (ISuperPower)sp;
        }
        static void FirePowers(ISuperPower superpower)
        {

        }

        static void ActivatePower(ISuperPower[] superheroes)
        {
            foreach (ISuperPower item in superheroes)
            {
                SpiderMan sp4 = (SpiderMan)item;

                //bool isSpiderman = item is SpiderMan;
                Console.WriteLine(item.GetType());

                // how to detect this is spiderman?
                if (item.GetType() == typeof(SpiderMan))
                {
                    SpiderMan sp1 = item as SpiderMan;
                    Console.WriteLine(sp1.RemainingWeb);

                    SpiderMan sp2 = (SpiderMan)item;
                }
                if (item is SpiderMan)
                {
                    SpiderMan sp3 = (SpiderMan)item;
                    Console.WriteLine(sp3.RemainingWeb);
                }
                SpiderMan sp = item as SpiderMan;
                if (sp != null)
                {
                    Console.WriteLine(sp.RemainingWeb);
                }

                item.ActivateSuperPowers();
            }
        }
    }
}
