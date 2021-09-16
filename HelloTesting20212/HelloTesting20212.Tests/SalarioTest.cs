using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
    public class TipoDeCambioFake : ITipoDeCambio
    {
        public decimal GetTipoDeCambioDolarActual()
        {
            return 4.11m;
        }

        public decimal GetTipoDeCambioEuroActual()
        {
            throw new NotImplementedException();
        }

        public decimal GetTipoDeCambioLibraActual()
        {
            return 6.1m;
        }

        public decimal GetTipoDeCambioPesoArgentinoActual()
        {
            throw new NotImplementedException();
        }

        public decimal GetTipoDeCambioPesoMexicanoActual()
        {
            throw new NotImplementedException();
        }
    }

    public class SalarioTest
    {
        [Test]
        public void SalarioSolesCaso01()
        {
            var e = new Empleado { Id = 1, Nombre = "Luis", SalarioSoles = 1000 };
            var s = new Salario(e, null);
            Assert.AreEqual(1000m, s.GetSalarioEnSoles());
        }

        [Test]
        public void SalarioDolaresCaso01()
        {
            var e = new Empleado { Id = 1, Nombre = "Luis", SalarioSoles = 1000 };
            var s = new Salario(e, new TipoDeCambioFake());
            Assert.AreEqual(4110m, s.GetSalarioEnDolares());
        }

        [Test]
        public void SalarioLibrasCaso01()
        {
            var e = new Empleado { Id = 1, Nombre = "Luis", SalarioSoles = 1000 };
            var s = new Salario(e, new TipoDeCambioFake());
            Assert.AreEqual(6100m, s.GetSalarioEnLibras());
        }
    }
}
