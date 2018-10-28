using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class Points
    {
        
        public double X { get; set; }
        public double Y { get; set; }

        public Points()
        {

        }

        public Points(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }
    }
}
