using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public class ArrayUtils
    {
        public int SumaPares(int[] numeros)
        {
            return numeros.Where(o => o % 2 == 0).Sum();
        }
    }
}
