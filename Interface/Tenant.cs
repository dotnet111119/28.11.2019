using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811int
{
    public abstract class Tenant : IRentDuty
    {
        public int money;
        public int Amount
        {
            get
            {
                return DateTime.Now.Hour;
            }
        }

        /*
public void PayArnona()
{
throw new NotImplementedException();
}

public void PayRent()
{
throw new NotImplementedException();
}
*/

        void IArnona.PayArnona()
        {
            throw new NotImplementedException();
        }
        /*
        void IRentDuty.PayRent()
        {
            throw new NotImplementedException();
        }
        */
        //public abstract void PayArnona();
        public abstract void PayRent();

        public int GetAmount()
        {
            throw new NotImplementedException();
        }
    }
}
