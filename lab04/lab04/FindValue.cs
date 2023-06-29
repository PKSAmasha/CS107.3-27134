using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class FindValue
    {
        public double findArea(double r)
        {
            double area = r * r * 22 / 7;
            return area;
        }
        public double findCircumference(double r)
        {
            double circumference = 2 * r * 22 / 7;
            return circumference;
        }

    }
}
