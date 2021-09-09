using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
    public class RomanoTest
    {
        [Test]
        public void Caso01()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Caso02()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(2);
            Assert.AreEqual("II", result);
        }

        [Test]
        public void Caso03()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(3);
            Assert.AreEqual("III", result);
        }

        [Test]
        public void Caso04()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(4);
            Assert.AreEqual("IV", result);
        }

        [Test]
        public void Caso05()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(5);
            Assert.AreEqual("V", result);
        }

        [Test]
        public void Caso06()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(6);
            Assert.AreEqual("VI", result);
        }

        [Test]
        public void Caso07()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(7);
            Assert.AreEqual("VII", result);
        }

        [Test]
        public void Caso08()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(8);
            Assert.AreEqual("VIII", result);
        }

        [Test]
        public void Caso09()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(9);
            Assert.AreEqual("IX", result);
        }

        [Test]
        public void Caso10()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(10);
            Assert.AreEqual("X", result);
        }

        [Test]
        public void Caso11()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(11);
            Assert.AreEqual("XI", result);
        }

        [Test]
        public void Caso12()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(12);
            Assert.AreEqual("XII", result);
        }

        [Test]
        public void Caso13()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(13);
            Assert.AreEqual("XIII", result);
        }

        [Test]
        public void Caso14()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(14);
            Assert.AreEqual("XIV", result);
        }

        [Test]
        public void Caso15()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(15);
            Assert.AreEqual("XV", result);
        }

        [Test]
        public void Caso16()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(16);
            Assert.AreEqual("XVI", result);
        }

        [Test]
        public void Caso17()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(17);
            Assert.AreEqual("XVII", result);
        }

        [Test]
        public void Caso18()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(18);
            Assert.AreEqual("XVIII", result);
        }

        [Test]
        public void Caso19()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(19);
            Assert.AreEqual("XIX", result);
        }

        [Test]
        public void Caso20()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(20);
            Assert.AreEqual("XX", result);
        }

        [Test]
        public void Caso30()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(30);
            Assert.AreEqual("XXX", result);
        }

        [Test]
        public void Caso40()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(40);
            Assert.AreEqual("XL", result);
        }


        [Test]
        public void Caso50()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(50);
            Assert.AreEqual("L", result);
        }

        [Test]
        public void Caso60()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(60);
            Assert.AreEqual("LX", result);
        }

        [Test]
        public void Caso144()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(144);
            Assert.AreEqual("CXLIV", result);
        }

        [Test]
        public void Caso444()
        {
            var romano = new Romano();
            var result = romano.ObtenerRomano(444);
            Assert.AreEqual("CDXLIV", result);
        }

    }
}
