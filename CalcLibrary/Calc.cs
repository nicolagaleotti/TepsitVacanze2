using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    class Calc
    {
        public static double RadQ (double num)
        {
            double resp = 0;
            if (num >= 0)
                resp = Math.Sqrt(num);
            else
                resp = double.NaN;
            return resp;
        }
    }
}
