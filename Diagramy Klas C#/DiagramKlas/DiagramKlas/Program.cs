using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramKlas
{
    class Program
    {
        static void Main(string[] args)
        {
            

            lepsze_liczby tak = new lepsze_liczby();
            tak.L1(11);
            tak.L2(35);
            tak.L3(82);
            tak.LL1(10);
            Console.WriteLine("a=" + tak.getL1() + ", b= " + tak.getL2() + ", c= " + tak.getL3() + ", d= " + tak.getLL1());
            Console.Read();
        }
    }
}
