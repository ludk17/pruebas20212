using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public interface IOperations {
        int Sumar(int a, int b);
    }

    public class Operations: IOperations
    {
        public int Sumar(int a, int b)
        {
            return a - b;
        }
    }
}
