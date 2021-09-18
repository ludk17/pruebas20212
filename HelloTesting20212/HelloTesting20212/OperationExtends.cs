using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public class OperationExtends
    {
        private readonly IOperations op;
        private readonly IYanKenPoGame game;
        private readonly ISalario salario;

        public OperationExtends(IOperations op, IYanKenPoGame game, ISalario salario)
        {
            this.op = op;
            this.game = game;
            this.salario = salario;
        }
        public int AddASuma(int a, int b, int c)
        {
            return op.Sumar(a, b) + c;
        }

        public Jugador GetGanadorYankenpo(Jugador j1, Jugador j2)
        {            
            game.SetJugador1(j1);
            game.SetJugador2(j2);

            return game.Ganador();
        }

        public decimal CalcularSalarioDolares(decimal salarioSoles)
        {      
            var tipoCambio = salario.GetTipoCambio();
            return tipoCambio.GetTipoDeCambioDolarActual() * salarioSoles; 
        }
    }
}
