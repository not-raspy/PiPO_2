using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    public class silnia
    {
        public int n;
        private int ans=1;
        public int Oblicz()
        {
            for (int i = 1; i <= n; i++){
                ans = i * ans;
            }
            return ans; 
        }
    }
}
