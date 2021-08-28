using HelloWorldTesting20212;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
    public class CarritoDeLibrosTest
    {
        private Libro HARRY_POTTER_1 = new Libro { Id = 1, Name = "Harry Potter y la Piedra Filosofal", Price = 20.5m };
        private Libro HARRY_POTTER_2 = new Libro { Id = 2, Name = "Harry Potter y la Camara de los secretos", Price = 20.5m };
        private Libro HARRY_POTTER_3 = new Libro { Id = 2, Name = "Harry Potter y el prisionero de Azkaban", Price = 20.5m };
        [Test]
        public void Caso01()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());

            var result = carrito.PrecioTotal();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Caso02()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());

            carrito.AddLibro(HARRY_POTTER_1);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(20.5m, result);
        }

        [Test]
        public void Caso03()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());

            carrito.AddLibro(HARRY_POTTER_1);
            carrito.AddLibro(HARRY_POTTER_2);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(41m, result);
        }

        [Test]
        public void Caso04()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());

            carrito.AddLibro(HARRY_POTTER_1);
            carrito.AddLibro(HARRY_POTTER_2);
            carrito.AddLibro(HARRY_POTTER_3);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(61.5m, result);
        }

        [Test]
        public void Caso05()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());

            carrito.AddLibro(HARRY_POTTER_1);
            carrito.AddLibro(HARRY_POTTER_2);
            carrito.QuitarLibro(HARRY_POTTER_2);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(20.5m, result);
        }

        [Test]
        public void Caso06()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());

            carrito.AddLibro(HARRY_POTTER_1);
            carrito.AddLibro(HARRY_POTTER_1);
            carrito.AddLibro(HARRY_POTTER_1);
            carrito.QuitarLibro(HARRY_POTTER_1);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(41m, result);
        }

        [Test]
        public void Caso07()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());

            carrito.AddLibro(HARRY_POTTER_1);
            carrito.AddLibro(HARRY_POTTER_1);
            carrito.AddLibro(HARRY_POTTER_1);
            carrito.QuitarLibro(HARRY_POTTER_1);
            carrito.QuitarLibro(HARRY_POTTER_1);
            carrito.QuitarLibro(HARRY_POTTER_1);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Caso08()
        {
            var carrito = new CarritoDeLibros(new List<Libro>());
           
            carrito.QuitarLibro(HARRY_POTTER_1);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Caso09()
        {
            var carrito = new CarritoDeLibros(new List<Libro> { HARRY_POTTER_1, HARRY_POTTER_2 });

            carrito.AddLibro(HARRY_POTTER_3);

            var result = carrito.PrecioTotal();
            Assert.AreEqual(61.5, result);
        }
    }
}
