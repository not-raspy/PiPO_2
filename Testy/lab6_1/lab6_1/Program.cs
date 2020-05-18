using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            silnia t = new silnia();
            t.n = 5; 
            Console.WriteLine("Wynikiem silni jest: " + t.Oblicz());
            Console.Read();
        }
    }
}
