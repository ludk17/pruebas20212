using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public class Romano
    {
        public string ObtenerRomano(int v)
        {
            string numero = "";
            while (v > 0)
            {
                if (v >= 500)
                {
                    numero += "D";
                    v -= 500;
                }
                else if (v >= 400)
                {
                    numero += "CD";
                    v -= 400;
                }
                else if (v >= 100)
                {
                    numero += "C";
                    v -= 100;
                }
                else if (v >= 90)
                {
                    numero += "XC";
                    v -= 90;
                }
                else if (v >= 50)
                {
                    numero += "L";
                    v -= 50;
                }
                else if (v >= 40)
                {
                    numero += "XL";
                    v -= 40;
                }
                else if (v >= 10)
                {
                    numero += "X";
                    v -= 10;
                }
                else if (v >= 9)
                {
                    numero += "IX";
                    v -= 9;
                }            
                
               
                else if (v >= 5)
                {
                    numero += "V";
                    v -= 5;
                }
                else if (v >= 4)
                {
                    numero += "IV";
                    v -= 4;
                }
               
                else if (v >= 1)
                {
                    numero += "I";
                    v -= 1;
                }
                
            }

            return numero;
        }
    }
}
