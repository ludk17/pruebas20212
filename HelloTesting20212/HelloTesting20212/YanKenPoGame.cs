using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public interface IYanKenPoGame
    {
        void SetJugador1(Jugador jugador);
        void SetJugador2(Jugador jugador);
        Jugador Ganador();
    }

    public class YanKenPoGame: IYanKenPoGame
    {
        private Jugador jugador1;
        private Jugador jugador2;

        public void SetJugador1(Jugador jugador)
        {
            this.jugador1 = jugador;
        }

        public void SetJugador2(Jugador jugador)
        {
            this.jugador2 = jugador;
        }

        public Jugador Ganador()
        {
            if (jugador1.Eleccion == jugador2.Eleccion)
                return null;
            if (jugador1.Eleccion == "Papel" & jugador2.Eleccion == "Piedra")
                return jugador1;
            else if (jugador1.Eleccion == "Piedra" & jugador2.Eleccion == "Tijera")
                return jugador1;
            else if (jugador1.Eleccion == "Tijera" & jugador2.Eleccion == "Papel")
                return jugador1;
            else
                return jugador2;
        }
    }
}
