using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212.Tests
{
    public class YanKenPoGameTest
    {
        [Test]
        public void Caso01()
        {
            var game = new YanKenPoGame();
           
            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Papel" });

            var result = game.Ganador();

            Assert.AreEqual("Jugador 1", result.Nombre);
        }


        [Test]
        public void Caso02()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Piedra" });

            var result = game.Ganador();

            Assert.AreEqual("Jugador 2", result.Nombre);
        }

        [Test]
        public void Caso03()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Papel" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Piedra" });

            var result = game.Ganador();

            Assert.AreEqual("Jugador 1", result.Nombre);
        }

        [Test]
        public void Caso04()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Papel" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual("Jugador 2", result.Nombre);
        }


        [Test]
        public void Caso05()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Piedra" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Papel" });

            var result = game.Ganador();

            Assert.AreEqual("Jugador 2", result.Nombre);
        }

        [Test]
        public void Caso06()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Piedra" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual("Jugador 1", result.Nombre);
        }

        [Test]
        public void Caso07()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Piedra" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Piedra" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso08()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Papel" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Papel" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso09()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso10()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso11()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso12()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso13()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso14()
        {
            var game = new YanKenPoGame();

            game.SetJugador1(new Jugador { Nombre = "Jugador 1", Eleccion = "Tijera" });
            game.SetJugador2(new Jugador { Nombre = "Jugador 2", Eleccion = "Tijera" });

            var result = game.Ganador();

            Assert.AreEqual(null, result);
        }
    }
}
