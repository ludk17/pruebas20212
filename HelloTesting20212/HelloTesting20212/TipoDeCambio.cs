using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTesting20212
{
    public interface ITipoDeCambio
    {
        decimal GetTipoDeCambioDolarActual();
        decimal GetTipoDeCambioEuroActual();
        decimal GetTipoDeCambioLibraActual();
        decimal GetTipoDeCambioPesoMexicanoActual();
        decimal GetTipoDeCambioPesoArgentinoActual();
    }

    //public class TipoDeCambio : ITipoDeCambio
    //{
    //    public decimal GetTipoDeCambioDolarActual()
    //    {
    //        // código que se va  a conectar con servicos externos para obtener el tipo de cammbio
    //        // var valor = getdesdeinternet();
    //        //throw new Exception();
    //        return 4.10m;
    //    }

    //    public decimal GetTipoDeCambioEuroActual()
    //    {
    //        // código que se va  a conectar con servicos externos para obtener el tipo de cammbio
    //        // var valor = getdesdeinternet();
    //        //throw new Exception();
    //        return 4.10m;
    //    }


    //    public decimal GetTipoDeCambioLibraActual()
    //    {
    //        // código que se va  a conectar con servicos externos para obtener el tipo de cammbio
    //        // var valor = getdesdeinternet();
    //        //throw new Exception();
    //        return 6.10m;
    //    }

    //    public decimal GetTipoDeCambioPesoMexicanoActual()
    //    {
    //        // código que se va  a conectar con servicos externos para obtener el tipo de cammbio
    //        // var valor = getdesdeinternet();
    //        //throw new Exception();
    //        return 4.10m;
    //    }

    //    public decimal GetTipoDeCambioPesoArgentinoActual()
    //    {
    //        // código que se va  a conectar con servicos externos para obtener el tipo de cammbio
    //        // var valor = getdesdeinternet();
    //        //throw new Exception();
    //        return 4.10m;
    //    }
    //}
}
