using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public class Salario
    {
        private readonly Empleado empleado;
        private readonly ITipoDeCambio tipoDeCambio;

        public Salario(Empleado empleado, ITipoDeCambio tipoDeCambio)
        {
            this.empleado = empleado;
            this.tipoDeCambio = tipoDeCambio;
        }

        public decimal GetSalarioEnSoles()
        {
            return empleado.SalarioSoles;
        }

        public decimal GetSalarioEnDolares()
        {            
            return empleado.SalarioSoles * tipoDeCambio.GetTipoDeCambioDolarActual();
        }

        public decimal GetSalarioEnLibras()
        {
            return empleado.SalarioSoles * tipoDeCambio.GetTipoDeCambioLibraActual();
        }
    }
}
