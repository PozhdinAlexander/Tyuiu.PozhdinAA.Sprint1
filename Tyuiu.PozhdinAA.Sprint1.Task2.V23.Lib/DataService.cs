using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PozhdinAA.Sprint1.Task2.V23.Lib
{
    public class DataService : ISprint1Task2V23
    {
        public int ConvertMinutesToSeconds(int value)
        {
            return 60 * value;
        }
    }
}
