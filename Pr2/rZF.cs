using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    public class rZF
    {
        public static double DOD(double x1, double x2) 
        {
            return x1 + x2;
        }
        public static double POD(double x1, double x2) 
        { 
            return x1 / x2; 
        }
        public static double VID(double x1, double x2)
        { 
            return x1 - x2; 
        }
        public static double POM(double x1, double x2) 
        {
            return x1* x2;
        }
    }
}
