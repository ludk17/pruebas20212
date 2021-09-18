using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
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
            
            var tcmock = new Mock<ITipoDeCambio>();
            tcmock.Setup(o => o.GetTipoDeCambioDolarActual()).Returns(4.11m);

            var s = new Salario(e, tcmock.Object);
            Assert.AreEqual(4110m, s.GetSalarioEnDolares());
        }

        [Test]
        public void SalarioLibrasCaso01()
        {
            var e = new Empleado { Id = 1, Nombre = "Luis", SalarioSoles = 1000 };

            var tcmock = new Mock<ITipoDeCambio>();
            tcmock.Setup(o => o.GetTipoDeCambioLibraActual()).Returns(6.1m);

            var s = new Salario(e, tcmock.Object);
            Assert.AreEqual(6100m, s.GetSalarioEnLibras());
        }
    }
}
