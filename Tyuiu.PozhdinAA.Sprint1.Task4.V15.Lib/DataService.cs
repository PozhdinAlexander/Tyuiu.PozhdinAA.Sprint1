using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PozhdinAA.Sprint1.Task4.V15.Lib
{
    public class DataService : ISprint1Task4V15
    {
        public double Calculate(double x, double y)
        {
            var res = (x + Math.Pow(y, 2)) / Math.Pow(Math.E, 2 - 4 * y);
            return Math.Round(res, 3);
        }
    }
}
