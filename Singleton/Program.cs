using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();

            // will generate same reference
            //Singleton s2 = Singleton.GetInstance();

            // will return true
            //Console.WriteLine(s1 == s2);

            // execute command from the singleton class...
            s1.GetConnection();
        }
    }
}
