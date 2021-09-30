using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
    public class CalculadoraTest
    {
        [Test]
        public void ProrbarSumaCaso01()
        {
            var calculadora = new Calculadora();
            var suma = calculadora.Sumar(3, 4);
            Assert.AreEqual(7, suma);
        }

        [Test]
        public void ProrbarSumaCaso02()
        {
            var calculadora = new Calculadora();
            var suma = calculadora.Sumar(4, 4);
            Assert.AreEqual(8, suma);
        }

        [Test]
        public void ProrbarSumaCaso03()
        {
            var calculadora = new Calculadora();
            var suma = calculadora.Sumar(3, 3);
            Assert.AreEqual(6, suma);
        }
    }
}
