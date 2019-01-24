using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesDemo2
{
    public delegate int NumberChanger(int number);
    class Calculator
    {
        public static int AddNum(int n)
        {
            n += 10;
            return n;
        }
    }
}
