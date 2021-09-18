using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
    public class OperationExtendsTest
    {
        [Test]
        public void AddSumaCaso01()
        {
            var mock = new Mock<IOperations>();
            mock.Setup(o => o.Sumar(It.IsAny<int>(), It.IsAny<int>())).Returns(15);

            var oe = new OperationExtends(mock.Object, null, null);
            
            var result1 = oe.AddASuma(4, 7, 10);
            Assert.AreEqual(25, result1);

            var result2 = oe.AddASuma(1, 4, 5);
            Assert.AreEqual(20, result2);
        }

        [Test]
        public void YankenPoGanadorCaso01()
        {
            var j1 = new Jugador { Nombre = "Luis", Eleccion = "Tijera" }; // ob2 //002
            var j2 = new Jugador { Nombre = "Pedro", Eleccion = "Piedra" }; // ob3 // 0003

            var mock = new Mock<IYanKenPoGame>();
            //mock.Setup(o => o.SetJugador1(new Jugador()));
            //mock.Setup(o => o.SetJugador2(new Jugador()));
            mock.Setup(o => o.Ganador()).Returns(j2);

            var oe = new OperationExtends(null, mock.Object, null);
           
            var r = oe.GetGanadorYankenpo(j1, j2);

            Assert.AreEqual(j2, r);
        }

        [Test]
        public void GetSalarioDolaresCaso01()
        {
            var mockTipoCambio = new Mock<ITipoDeCambio>();
            mockTipoCambio.Setup(o => o.GetTipoDeCambioDolarActual()).Returns(4.11m);

            var mockSalario = new Mock<ISalario>();
            mockSalario.Setup(o => o.GetTipoCambio()).Returns(mockTipoCambio.Object);

            var oe = new OperationExtends(null, null, mockSalario.Object);
            var r = oe.CalcularSalarioDolares(1000);

            Assert.AreEqual(4110, r);
        }
    }
}
