using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class MyMath
    {
        public static double Pow(int value, int pow)
        {
            if (pow == 0)
                return 1;
            if (pow > 0)
                return Pow(value, pow - 1) * value;
            return 1.0 / Pow(value, -pow);
        }
    }
}
