using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramKlas
{
    public class lepsze_liczby : Liczby
    {
        private int d;
        public lepsze_liczby()
        {
            LL1(0);
        }

        public void LL1()
        {
            throw new System.NotImplementedException();
        }

        public int getLL1()
        {
            return d;
        }

        public void LL1(int d)
        {
            this.d = d;
        }
    }
}