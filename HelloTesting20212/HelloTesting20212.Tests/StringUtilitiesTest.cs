using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldTesting20212;

namespace HelloTesting20212.Tests
{
    public class StringUtilitiesTest
    {
        [Test]
        public void EsPalindromeCasoPrueba01()
        {
            // cuatro fases 
            // 1. Intanciar la clase que voy a testear
            var utils = new StringUtilities();
            // 2. Prepar los datos a enviar
            string texto = "hello";
            // 3. Invocar al metodo a testear con los datos de prueba
            var result = utils.EsPalindrome(texto);
            // 4. Comprobar resultado con deseado
            Assert.AreEqual(false, result);
        }

        [Test]
        public void EsPalindromeCasoPrueba02()
        {
            var utils = new StringUtilities();
            string texto = "oso";
            var result = utils.EsPalindrome(texto);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void EsPalindromeCasoPrueba03()
        {
            var utils = new StringUtilities();
            string texto = "anita lava la tina";
            var result = utils.EsPalindrome(texto);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void EsPalindromeCasoPrueba04()
        {
            var utils = new StringUtilities();
            string texto = "Anita lava la tina";
            var result = utils.EsPalindrome(texto);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void EsPalindromeCasoPrueba05()
        {
            var utils = new StringUtilities();
            string texto = "osó";
            var result = utils.EsPalindrome(texto);
            Assert.AreEqual(true, result);
        }


        [Test]
        public void EsPalindromeCasoPrueba06()
        {
            var utils = new StringUtilities();
            string texto = "çac";
            var result = utils.EsPalindrome(texto);
            Assert.AreEqual(true, result);
        }


        [Test]
        public void ConvertArrayToStringCasoPrueba01()
        {
            var utils = new StringUtilities();
            var arr = new string[] { "hola", "mundo" };
            var result = utils.ConvertArrayToString(arr);
            Assert.AreEqual("hola mundo", result);
        }

        [Test]
        public void ConvertArrayToStringCasoPrueba02()
        {
            var utils = new StringUtilities();
            var arr = new string[] { "hello", "world" };
            var result = utils.ConvertArrayToString(arr);
            Assert.AreEqual("hello world", result);
        }

        [Test]
        public void ConvertArrayToStringCasoPrueba03()
        {
            var utils = new StringUtilities();
            var arr = new string[] { "hacer", "unit", "testing", "es", "facil" };
            var result = utils.ConvertArrayToString(arr);
            Assert.AreEqual("hacer unit testing es facil", result);
        }


        [Test]
        public void SortPalabrasCasoPrueba01()
        {
            var utils = new StringUtilities();

            utils.AddPalabra("piraña");
            utils.AddPalabra("gato");
            utils.AddPalabra("perro");

            Assert.AreEqual(new string[] { "piraña", "gato", "perro"}, utils.GetPalabras());

            utils.SortPalabras();
            
            Assert.AreEqual(new string[] { "gato", "perro", "piraña" }, utils.GetPalabras());
        }


        [Test]
        public void SortPalabrasCasoPrueba02()
        {
            var utils = new StringUtilities();

            utils.AddPalabra("hugo");
            utils.AddPalabra("pedro");

            Assert.AreEqual(new string[] { "hugo", "pedro" }, utils.GetPalabras());

            utils.SortPalabras();

            Assert.AreEqual(new string[] { "hugo", "pedro" }, utils.GetPalabras());
        }


    }
}
