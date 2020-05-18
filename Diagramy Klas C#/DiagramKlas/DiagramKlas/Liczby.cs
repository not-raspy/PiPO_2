using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramKlas
{
    public class Liczby
    {
        private int a;
        private int b;
        private int c;
        public Liczby()
        {
            L1(0);
            L2(0);
            L3(0);
        }

        public void L1(int a)
        {
            this.a = a;
        }

        public void L2(int b)
        {
            this.b = b; 
        }

        public int getL1()
        {
            return a;
        }

        public int getL2()
        {
            return b;
        }

        public void L3(int c)
        {
            this.c = c;
        }

        public int getL3()
        {
            return c;
        }
    }
    public struct liczby
    {
    }
}